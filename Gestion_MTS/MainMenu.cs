using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_MTS
{
    using Context;

    public partial class MainMenu : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public MainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Productos(), sender);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Empleados(), sender);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Facturas(), sender);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //SubMenuReportes.Visible = true;
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmReporteVentas(), sender);
            //SubMenuReportes.Visible = false;
        }

        private void btnReporteServicios_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmReporteServicios(), sender);
            //SubMenuReportes.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            int userRole = AppContext.GetContext().roleId;

            if ((UserRoles)userRole != UserRoles.Admin)
            {
                btnArqueo.Hide();
                btnEmpleados.Hide();
                btnInventario.Hide();
                btnServicios.Hide();
                btnSucursales.Hide();
                btnUsers.Hide();
                btnInfoAdicional.Hide();
            }
        }

        private void btnArqueo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Arqueo(), sender);
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdmonSucursales(), sender);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Servicios(), sender);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                return;
            }

            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Usuarios(), sender);
        }

        private void btnInfoAdicional_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Informacion_Adicional(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Context.AppContext.LogOut();
            this.Hide();

            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}

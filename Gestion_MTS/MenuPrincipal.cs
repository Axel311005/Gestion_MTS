using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Gestion_MTS
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnVentana.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnVentana.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = true;
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void btnReporteServicios_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void btnDesplegable_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 220)
            {
                MenuVertical.Width = 40;
                ImageLogo.Visible = false;
            }
            else
            {
                MenuVertical.Width = 220;
                ImageLogo.Visible = true;
            }
        }
    }
}

using Gestion_MTS.Clases;
using Gestion_MTS.Context;
using Gestion_MTS.IRepository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_MTS
{
    using BCrypt.Net;
    public partial class Login : Form
    {

        private string db_connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtUserName.Text.Trim() == "") {
                MessageBox.Show("Todos los campos son obligatorios!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioRepository usuarioRepository = new UsuarioRepository(db_connection);

            try
            {
                Usuario? actualUser = usuarioRepository.GetByUserName(txtUserName.Text.Trim());

                if (actualUser == null) {
                    MessageBox.Show("No se encontro un usuario con los datos especificados", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!BCrypt.Verify(txtPassword.Text.Trim(), actualUser.Contraseña))
                {
                    MessageBox.Show("Contraseña incorrecta", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int? userRole = usuarioRepository.GetUserRole(actualUser.IdUsuario);

                if (userRole == null)
                {
                    MessageBox.Show("Usuario sin rol asociado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Context.AppContext context = new Context.AppContext(
                    new ContextData(
                        actualUser.IdUsuario,
                        (int)userRole
                    )    
                );

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();

                this.Hide();
            }
            catch (Exception ex) {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
                return;
            }

            this.WindowState = FormWindowState.Normal;
        }
    }
}

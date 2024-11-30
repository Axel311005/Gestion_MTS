using BCrypt.Net;
using Gestion_MTS.Clases;
using Gestion_MTS.IRepository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_MTS
{
    using BCrypt.Net;
    public partial class Usuarios : Form
    {
        private string db_connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            EmpleadoRepository empleadoRepo = new EmpleadoRepository(db_connection);

            var empleados = empleadoRepo.GetAll();

            cmbEmployeeId.DataSource = empleados;
            cmbEmployeeId.DisplayMember = "nombre";
            cmbEmployeeId.ValueMember = "id_empleado";
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            string trimmedUserName = txtUserName.Text.Trim();
            string trimmedPassword = txtPassword.Text.Trim();

            if (trimmedUserName == "" || trimmedPassword == "")
            {
                MessageBox.Show("Todos los campos son obligatorios!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario user = new Usuario
            {
                NombreUsuario = trimmedUserName,
                Contraseña = BCrypt.HashPassword(trimmedPassword, BCrypt.GenerateSalt()),
                IdEmpleado = Convert.ToInt32(cmbEmployeeId.SelectedValue)
            };

            UsuarioRepository userRepo = new UsuarioRepository(db_connection);

            try
            {
                userRepo.Add(user);

                MessageBox.Show("Usuario creado correctamente!", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

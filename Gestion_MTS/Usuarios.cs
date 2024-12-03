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
        private int selectedUserId;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            EmpleadoRepository empleadoRepo = new EmpleadoRepository(db_connection);
            UsuarioRepository userRepo = new UsuarioRepository(db_connection);

            var empleados = empleadoRepo.GetEmployeesSimplified();

            cmbEmployeeId.DataSource = empleados;
            cmbEmployeeId.DisplayMember = "nombre";
            cmbEmployeeId.ValueMember = "id_empleado";

            dgvUsers.DataSource = userRepo.GetAll();
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

                Usuarios_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                try
                {
                    selectedUserId = (int)dgvUsers.SelectedRows[0].Cells[0].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selecciona un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtUserName.Text = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();

                lblNewPass.Visible = true;
                txtNewPass.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository(db_connection);

            try
            {
                Usuario? actualUser = usuarioRepository.GetByUserName(dgvUsers.SelectedRows[0].Cells[1].Value.ToString());

                if (actualUser == null)
                {
                    MessageBox.Show("No se encontro un usuario con los datos especificados", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BCrypt.Verify(txtPassword.Text.Trim(), actualUser.Contraseña))
                {
                    MessageBox.Show("Contraseña incorrecta", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string trimmedPassword = txtNewPass.Text.Trim();

                usuarioRepository.Update(
                    new Usuario
                    {
                        IdEmpleado = Convert.ToInt32(cmbEmployeeId.SelectedValue),
                        NombreUsuario = txtUserName.Text.Trim(),
                        IdUsuario = selectedUserId,
                        Contraseña = trimmedPassword != "" ? 
                            BCrypt.HashPassword(trimmedPassword, BCrypt.GenerateSalt())
                            : null
                    },
                    selectedUserId
                );

                MessageBox.Show("Usuario Actualizado Correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Usuarios_Load(sender, e);
            } catch(Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository(db_connection);

                usuarioRepository.Delete(selectedUserId);

                MessageBox.Show("Usuario Eliminado Correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Usuarios_Load(sender, e);
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_MTS.Clases;
using Gestion_MTS.ConsultasAdo.Net;
using Gestion_MTS.IRepository.Repository;
using Gestion_MTS.Vistas;

namespace Gestion_MTS
{
    public partial class Empleados : Form
    {

        EmpleadoRepository empleado;
        SucursalRepository sucursal;
        RolRepository rol;


        public int idEmp;
        public int idRol;

        public Empleados()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            empleado = new EmpleadoRepository(connectionString);
            sucursal = new SucursalRepository(connectionString);
            rol = new RolRepository(connectionString);

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Refresh();
            

        }

        private void Refresh()
        {
            try
            {

                var empleados = empleado.GetAll();
                dgvEmpleados.DataSource = empleados;
                var roles = rol.GetAll();
                dgvRoles.DataSource = roles;
                cboSucursal.DataSource = sucursal.GetUbicacionSucursal();
                cboRoles.DataSource = rol.GetRoles();


            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarTextRol()
        {
            txtNombreRol.Clear();
            txtDescRol.Clear();
        }

        private void btnAddEmpleado_Click(object sender, EventArgs e)
        {

            try
            {

                int id_rol = Convert.ToInt32(rol.GetIdRol(cboRoles.Text));
                int id_sucursal = Convert.ToInt32(sucursal.GetIdSucursal(cboSucursal.Text));

                Empleado newEmpleado = new Empleado
                {
                    nombre = txtNombreEmpleado.Text,
                    apellido = txtApellidoEmpleado.Text,
                    salario = Convert.ToDecimal(txtSalario.Text),
                    fecha_nacimiento = dtpNacimiento.Value,
                    cedula = txtCedula.Text,
                    celular = txtCelular.Text,
                    direccion = txtDireccion.Text,
                    id_rol = id_rol,
                    id_sucursal = id_sucursal
                };

                empleado.Add(newEmpleado);
                MessageBox.Show("Empleado Agregado correctamente");
                Refresh();
                LimpiarText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado " + ex.Message);
            }
        }

        private void btnAddRol_Click(object sender, EventArgs e)
        {
            try
            {
                Rol roles = new Rol
                {
                    nombre = txtNombreRol.Text,
                    descripcion = txtDescRol.Text
                };

                rol.Add(roles);
                MessageBox.Show("Rol Agregado correctamente");
                LimpiarTextRol();
                Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el rol " + ex.Message);
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

                
                VistaEmpleados empleados = new VistaEmpleados
                {
                    Nombre = row.Cells["Nombre"].Value?.ToString(),
                    Apellido = row.Cells["Apellido"].Value?.ToString(),
                    Cumpleaños = row.Cells["Cumpleaños"].Value != null
                                  ? Convert.ToDateTime(row.Cells["Cumpleaños"].Value)
                                  : DateTime.MinValue,
                    Identificación = row.Cells["Identificación"].Value?.ToString(),
                    celular = row.Cells["celular"].Value?.ToString(),
                    direccion = row.Cells["direccion"].Value?.ToString(),
                    Rol = row.Cells["Rol"].Value?.ToString(),
                    Sucursal = row.Cells["Sucursal"].Value?.ToString(),
                    estado = Convert.ToBoolean(row.Cells["estado"].Value)
                };

                // Llena los controles con los datos del objeto empleado
                idEmp = Convert.ToInt32(row.Cells["id_empleado"].Value);
                txtNombreEmpleado.Text = empleados.Nombre;
                txtApellidoEmpleado.Text = empleados.Apellido;
                txtCedula.Text = empleados.Identificación;
                txtCelular.Text = empleados.celular;
                txtDireccion.Text = empleados.direccion;
                dtpNacimiento.Value = empleados.Cumpleaños;
                cboRoles.Text = empleados.Rol;
                cboSucursal.Text = empleados.Sucursal;
                txtSalario.Text = empleado.ObtenerSalarioPorId(idEmp).ToString();
                chbEstado.Checked = empleados.estado;
            }
        }
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoles.Rows[e.RowIndex];

                Rol rol = new Rol
                {
                    nombre = row.Cells["nombre"]?.Value?.ToString(),
                    descripcion = row.Cells["descripcion"]?.Value?.ToString()
                };
                idRol = Convert.ToInt32(row.Cells["id_rol"].Value);
                txtNombreRol.Text = rol.nombre;
                txtDescRol.Text = rol.descripcion;
            }
        }

        private void btnUpdateEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {

                try
                {
                    int id_rol = Convert.ToInt32(rol.GetIdRol(cboRoles.Text));
                    int id_sucursal = Convert.ToInt32(sucursal.GetIdSucursal(cboSucursal.Text));
                    var update = new Empleado
                    {
                        id_empleado = idEmp,
                        nombre = txtNombreEmpleado.Text,
                        apellido = txtApellidoEmpleado.Text,
                        salario = Convert.ToDecimal(txtSalario.Text),
                        fecha_nacimiento = dtpNacimiento.Value,
                        cedula = txtCedula.Text,
                        celular = txtCelular.Text,
                        direccion = txtDireccion.Text,
                        id_rol = id_rol,
                        id_sucursal = id_sucursal,
                        estado = chbEstado.Checked
                    };

                    empleado.Update(update, 0);
                    MessageBox.Show("Empleado Actualizado correctamente");
                    Refresh();
                    LimpiarText();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al actualizar el empleado " + ex.Message);
                }

            }
        }
        private void btnUpdateRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Rol
                    {
                        id_rol = idRol,
                        nombre = txtNombreRol.Text,
                        descripcion = txtDescRol.Text,
                    };

                    rol.Update(update, 0);
                    MessageBox.Show("Rol actualizado correctamente");
                    LimpiarTextRol();
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el rol " + ex.Message);
                }
            }
        }


        private void btnDeleteEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count > 0)
            {

                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar el empleado '{txtNombreEmpleado.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        empleado.Delete(idEmp);
                        MessageBox.Show("¡Empleado eliminado exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        LimpiarText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar empleado: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.Rows.Count > 0)
            {
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar el rol '{txtNombreRol.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        rol.Delete(idRol);
                        Refresh();
                        LimpiarTextRol();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar rol: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void LimpiarText()
        {
            txtNombreEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            txtCedula.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();


        }

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }


            if (e.KeyChar == '-')
            {

                if (textBox.Text.Length != 4)
                {
                    e.Handled = true;
                }
                return;
            }


            if (textBox.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            // aca no permite que tenga mas de dos puntos para un decimal 
            if ((sender as TextBox).Text.Contains("."))
            {
                string[] parts = (sender as TextBox).Text.Split('.');
                if (parts.Length > 1 && parts[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtDescRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }
    }
}

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
            cboSucursal.DataSource = sucursal.GetUbicacionSucursal();
            cboRoles.DataSource = rol.GetRoles();

        }

        private void Refresh()
        {
            try
            {

                var empleados = empleado.GetAll();
                dgvEmpleados.DataSource = empleados;


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

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada del DataGridView
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

                // Mapea los datos manualmente desde las celdas a un objeto VistaEmpleados
                VistaEmpleados empleado = new VistaEmpleados
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
                    Sucursal = row.Cells["Sucursal"].Value?.ToString()
                };

                // Llena los controles con los datos del objeto empleado
                txtNombreEmpleado.Text = empleado.Nombre;
                txtApellidoEmpleado.Text = empleado.Apellido;
                txtCedula.Text = empleado.Identificación;
                txtCelular.Text = empleado.celular;
                txtDireccion.Text = empleado.direccion;
                dtpNacimiento.Value = empleado.Cumpleaños;
                cboRoles.Text = empleado.Rol;
                cboSucursal.Text = empleado.Sucursal;

                // Si necesitas agregar salario
                txtSalario.Text = ""; // Método pendiente para obtener salario
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
                        id_empleado = empleado.ObtenerIdEmpleadoPorNombre(txtNombreEmpleado.Text, txtApellidoEmpleado.Text),
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
                        empleado.Delete(empleado.ObtenerIdEmpleadoPorNombre(txtNombreEmpleado.Text, txtApellidoEmpleado.Text));
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}

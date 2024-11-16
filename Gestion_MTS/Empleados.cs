using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_MTS.ConsultasAdo.Net;

namespace Gestion_MTS
{
    public partial class Empleados : Form
    {
        ConsultasEmpleados emp = new ConsultasEmpleados();
        ConsultasAdmonBodegas bod = new();

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Refresh();
            cboSucursal.DataSource = bod.GetSucursales();
            cboRoles.DataSource = emp.GetRoles();

        }

        private void Refresh()
        {
            try
            {

                var empleados = emp.GetEmpleados(); // Almacena en una variable
                dgvEmpleados.DataSource = empleados; // Asigna solo si hay empleados


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

            int id_rol = Convert.ToInt32(emp.GetIdRol(cboRoles.Text));
            int id_sucursal = Convert.ToInt32(bod.GetIdSucursal(cboSucursal.Text));

            emp.AddEmpleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, Convert.ToDecimal(txtSalario.Text),
                dtpNacimiento.Value, txtCedula.Text, txtCelular.Text, txtDireccion.Text, id_rol, id_sucursal);
            MessageBox.Show("Empleado Agregado correctamente");
            Refresh();
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado " + ex.Message);
            }
        }
    }
}

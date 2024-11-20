using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_MTS.Clases;
using Gestion_MTS.ConsultasAdo.Net;
using Gestion_MTS.IRepository.Repository;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado " + ex.Message);
            }
        }
    }
}

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
    public partial class Facturas : Form
    {
        private string _connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        private List<DetalleServicioDto> servicios = new List<DetalleServicioDto>();
        private List<DetalleProducto> productos = new List<DetalleProducto>();

        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            ProductoRepository productoRepository = new ProductoRepository(_connection);
            ServicioRepository servicioRepository = new ServicioRepository(_connection);
            EmpleadoRepository empleadoRepository = new EmpleadoRepository(_connection);

            var products = productoRepository.GetSimplifiedProducts();

            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "nombre";
            cmbProducts.ValueMember = "id_producto";

            var services = servicioRepository.GetSimplifiedServices();

            cmbServicios.DataSource = services;
            cmbServicios.DisplayMember = "nombre";
            cmbServicios.ValueMember = "id_servicio";

            var mechanics = empleadoRepository.GetMechanicEmployees();

            cmbEmpleados.DataSource = mechanics;
            cmbEmpleados.DisplayMember = "nombre";
            cmbEmpleados.ValueMember = "id_empleado";
        }

        private void lblAddedProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductQuantity.Text.Trim() == "") {
                MessageBox.Show("El campo cantidad es obligatorio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProductQuantity.Text, out var quantity)) {
                MessageBox.Show("El campo cantidad debe ser un numero entero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            productos.Add(
                new DetalleProducto
                {
                    IdProducto = Convert.ToInt32(cmbProducts.SelectedValue)
                    Cantidad = quantity
                }
            );
        }
    }
}

using Gestion_MTS.Clases;
using Gestion_MTS.DTOs;
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
        private List<DetalleProductoDto> productos = new List<DetalleProductoDto>();

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
            if (txtProductQuantity.Text.Trim() == "")
            {
                MessageBox.Show("El campo cantidad es obligatorio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProductQuantity.Text, out var quantity))
            {
                MessageBox.Show("El campo cantidad debe ser un numero entero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productIdx = productos.FindIndex(p => p.IdProducto == Convert.ToInt32(cmbProducts.SelectedValue));

            if (productIdx != -1)
            {
                productos[productIdx].Cantidad += quantity;
                RefreshData();
                return;
            }

            productos.Add(
                new DetalleProductoDto
                {
                    IdProducto = Convert.ToInt32(cmbProducts.SelectedValue),
                    Cantidad = quantity,
                    NombreProducto = cmbProducts.Text,
                }
            );

            RefreshData();
        }

        private void RefreshData()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productos;

            dgvServices.DataSource = null;
            dgvServices.DataSource = servicios;

            dgvProducts.Columns["IdProducto"].Visible = false;
            dgvServices.Columns["IdServicio"].Visible = false;
            dgvServices.Columns["IdEmpleado"].Visible = false;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("El campo monto es obligatorio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out var amount))
            {
                MessageBox.Show("El campo monto debe ser un numero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            servicios.Add(
                new DetalleServicioDto
                {
                    IdServicio = Convert.ToInt32(cmbServicios.SelectedValue),
                    IdEmpleado = Convert.ToInt32(cmbEmpleados.SelectedValue),
                    NombreEmpleado = cmbEmpleados.Text,
                    NombreServicio = cmbServicios.Text,
                    Amount = amount
                }
            );

            RefreshData();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedProduct = (DetalleProductoDto)dgvProducts.SelectedRows[0].DataBoundItem;

                txtProductQuantity.Text = selectedProduct.Cantidad.ToString();
                cmbProducts.SelectedValue = selectedProduct.IdProducto;
            }
        }
    }
}

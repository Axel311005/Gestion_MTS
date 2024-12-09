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
            ClienteRepository clienteRepository = new ClienteRepository(_connection);
            TipoPagoRepository tipoPagoRepository = new TipoPagoRepository(_connection);

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

            var clients = clienteRepository.GetClientsSimplified();

            cmbCliente.DataSource = clients;
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "id_cliente";

            var tiposPago = tipoPagoRepository.GetTiposPagoSimplified();

            cmbTipoPago.DataSource = tiposPago;
            cmbTipoPago.DisplayMember = "tipo";
            cmbTipoPago.ValueMember = "id_tipo_pago";
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

            if (!int.TryParse(txtProductQuantity.Text, out var quantity) || quantity <= 0)
            {
                MessageBox.Show("El campo cantidad debe ser un numero entero mayor a 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (!decimal.TryParse(txtAmount.Text, out var amount) || amount <= 0)
            {
                MessageBox.Show("El campo monto debe ser un numero mayor a 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int serviceIdx = servicios.FindIndex(s => s.IdServicio == Convert.ToInt32(cmbServicios.SelectedValue));

            if (serviceIdx != -1)
            {
                MessageBox.Show("Ya has añadido este servicio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnUpdateRequestedProduct_Click(object sender, EventArgs e)
        {
            int productIdx = productos.FindIndex(p => p.IdProducto == Convert.ToInt32(cmbProducts.SelectedValue));

            if (productIdx == -1)
            {
                MessageBox.Show("No puedes actualizar un producto que aun no ha sido añadido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtProductQuantity.Text.Trim() == "")
            {
                MessageBox.Show("El campo cantidad es obligatorio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProductQuantity.Text, out var quantity) || quantity <= 0)
            {
                MessageBox.Show("El campo cantidad debe ser un numero entero mayor 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            productos[productIdx].Cantidad = quantity;
            RefreshData();
        }

        private void btnDeleteRequestedProduct_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show(
                "Estas seguro de que quieres eliminar este producto de la factura?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogRes == DialogResult.No)
            {
                return;
            }

            DetalleProductoDto? detalleProducto = productos.Find(p => p.IdProducto == Convert.ToInt32(cmbProducts.SelectedValue));

            if (detalleProducto == null)
            {
                MessageBox.Show("No se encontro el detalle especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productos.Remove(detalleProducto);
            RefreshData();
            MessageBox.Show("Detalle Eliminado Correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedService = (DetalleServicioDto)dgvServices.SelectedRows[0].DataBoundItem;

                txtAmount.Text = selectedService.Amount.ToString();
                cmbServicios.SelectedValue = selectedService.IdServicio;
                cmbEmpleados.SelectedValue = selectedService.IdEmpleado;
            }
        }

        private void btnUpdateRequestedService_Click(object sender, EventArgs e)
        {
            int serviceIdx = servicios.FindIndex(p => p.IdServicio == Convert.ToInt32(cmbServicios.SelectedValue));

            if (serviceIdx == -1)
            {
                MessageBox.Show("No puedes actualizar un servicio que aun no ha sido añadido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("El campo monto es obligatorio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out var amount) || amount <= 0)
            {
                MessageBox.Show("El campo monto debe ser un numero mayor a 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            servicios[serviceIdx].Amount = amount;
            RefreshData();
        }

        private void btnDeleteRequestedService_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show(
                "Estas seguro de que quieres eliminar este servicio de la factura?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogRes == DialogResult.No)
            {
                return;
            }

            DetalleServicioDto? detalleServicio = servicios.Find(p => p.IdServicio == Convert.ToInt32(cmbServicios.SelectedValue));

            if (detalleServicio == null)
            {
                MessageBox.Show("No se encontro el detalle especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            servicios.Remove(detalleServicio);
            RefreshData();
            MessageBox.Show("Detalle Eliminado Correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void txtProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

       private void btnGenerateFactura_Click(object sender, EventArgs e)
        {
            if(productos.Count < 1 && servicios.Count < 1)
            {
                MessageBox.Show("Necesita agregar productos o servicios a la factura", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FacturaRepository facturaRepo = new FacturaRepository(this._connection);

            int? idEmpleado = Context.AppContext.GetContext().GetEmployeeId();

            if(idEmpleado == null)
            {
                MessageBox.Show("No se encontro el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idFactura = facturaRepo.AddFactura(
                new Factura
                {
                     IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),
                     IdEmpleado = idEmpleado.Value,
                     IdTipoPago = Convert.ToInt32(cmbTipoPago.SelectedValue)
                }
            );


            if(idFactura == 0)
            {
                MessageBox.Show("Ocurrio un error al crear la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            facturaRepo.AddFacturaDetails(
                new Tuple<List<DetalleProductoDto>, List<DetalleServicioDto>>(productos, servicios),
                idFactura
            );

            ImprimirFactura impFacturaForm = new ImprimirFactura(idFactura);

            impFacturaForm.Show();
        }
    }
}

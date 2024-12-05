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
using Gestion_MTS.Vistas;

namespace Gestion_MTS
{
    public partial class Productos : Form
    {

        ProductoRepository productos;
        CategoriaProductoRepository categoria;
        LocalizacionEnBodegaRepository local;
        public Productos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            productos = new ProductoRepository(connectionString);
            categoria = new CategoriaProductoRepository(connectionString);
            local = new LocalizacionEnBodegaRepository(connectionString);

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Refresh();
            cboCategoria.DataSource = categoria.GetCategoria();
            cboLocalicacion.DataSource = local.GetLocalizacion();
        }

        private void Refresh()
        {
            try
            {

                var products = productos.GetAll();
                dgvProductos.DataSource = products;
                dgvCategorias.DataSource = categoria.GetAll();


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
        public void LimpiarProductos()
        {
            txtCodigo.Clear();
            txtDescripProd.Clear();
            txtNombreProd.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtStockMin.Clear();
            chkEstado.Checked = false;

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                Producto newProduct = new Producto
                {
                    Codigo = txtCodigo.Text,
                    Estado = chkEstado.Checked,
                    Descripcion = txtDescripProd.Text,
                    Nombre = txtNombreProd.Text,
                    PrecioUnitario = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    StockMinimo = Convert.ToInt32(txtStockMin.Text),
                    IdCategoriaProducto = categoria.GetIdCategoria(cboCategoria.Text),
                    IdLocalizacionBodega = local.GetId(cboLocalicacion.Text),

                };

                productos.Add(newProduct);
                MessageBox.Show("Producto agregado correctamente");
                Refresh();
                LimpiarProductos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaProducto newCategoria = new CategoriaProducto
                {
                    Nombre = txtNombreCategoria.Text,
                    Descripcion = txtDescripcionCateg.Text,
                };

                categoria.Add(newCategoria);
                MessageBox.Show("Categoria agregada correctamente");
                txtNombreCategoria.Clear();
                txtDescripcionCateg.Clear();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Producto
                    {
                        IdProducto = productos.ObtenerIdProductoPorNombre(txtNombreProd.Text),
                        Codigo = txtCodigo.Text,
                        Estado = chkEstado.Checked,
                        Descripcion = txtDescripProd.Text,
                        Nombre = txtNombreProd.Text,
                        PrecioUnitario = Convert.ToDecimal(txtPrecio.Text),
                        Stock = Convert.ToInt32(txtStock.Text),
                        StockMinimo = Convert.ToInt32(txtStockMin.Text),
                        IdCategoriaProducto = categoria.GetIdCategoria(cboCategoria.Text),
                        IdLocalizacionBodega = local.GetId(cboLocalicacion.Text),
                    };

                    productos.Update(update, 0);
                    MessageBox.Show("Producto Actualizado correctamente");
                    Refresh();
                    LimpiarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el producto " + ex.Message);
                }
            }
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {

                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar el producto '{txtNombreProd.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        productos.Delete(productos.ObtenerIdProductoPorNombre(txtNombreProd.Text));
                        MessageBox.Show("¡Producto eliminado exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        LimpiarProductos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar Producto: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                VistaProductos product = new VistaProductos
                {
                    nombre = row.Cells["nombre"].Value?.ToString(),
                    codigo = row.Cells["codigo"].Value?.ToString(),
                    categoria = row.Cells["categoria"].Value?.ToString(),
                    descripcion = row.Cells["descripcion"].Value?.ToString(),
                    precio = Convert.ToDecimal(row.Cells["precio"].Value),
                    stock = Convert.ToInt32(row.Cells["stock"].Value),
                    StockMinimo = Convert.ToInt32(row.Cells["StockMinimo"].Value),
                    sucursal = row.Cells["sucursal"].Value?.ToString(),
                    bodega = row.Cells["bodega"].Value?.ToString(),
                    localizacion = row.Cells["localizacion"].Value?.ToString(),
                    estado = Convert.ToBoolean(row.Cells["estado"].Value)
                };

                txtCodigo.Text = product.codigo;
                txtNombreProd.Text = product.nombre;
                txtDescripProd.Text = product.descripcion;
                txtPrecio.Text = product.precio.ToString();
                txtStock.Text = product.stock.ToString();
                txtStockMin.Text = product.StockMinimo.ToString();
                cboCategoria.Text = product.categoria;
                cboLocalicacion.Text = product.localizacion;
                chkEstado.Checked = product.estado;

            }
        }

        private void txtNombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescripProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //en este en especifico admite el '.' para los decimales y solo numeros o si no los bloquea
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        //solo numeros positivos
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescripcionCateg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

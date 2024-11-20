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
    }
}

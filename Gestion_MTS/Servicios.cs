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
    public partial class Servicios : Form
    {
        ServicioRepository servicio;
        CategoriaServicioRepository categoria;
        public Servicios()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            servicio = new ServicioRepository(connectionString);
            categoria = new CategoriaServicioRepository(connectionString);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddServicio_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio newServicio = new Servicio
                {
                    Nombre = txtNombreServ.Text,
                    Descripcion = txtDescripServ.Text,
                    IdCategoriaServicio = categoria.GetId(cboCategoria.Text)
                };

                servicio.Add(newServicio);
                MessageBox.Show("Servicio Agregado correctamente");
                txtDescripServ.Clear();
                txtNombreServ.Clear();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        public void Refresh()
        {
            dgvServicios.DataSource = servicio.GetAll();
            cboCategoria.DataSource = categoria.GetCategoria();
            dgvCategoriaServicios.DataSource = categoria.GetAll();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaServicio newCategoria = new CategoriaServicio
                {
                    Nombre = txtNombreCategoria.Text,
                    Descripcion = txtDescripcionCateg.Text,
                };

                categoria.Add(newCategoria);    
                txtNombreCategoria.Clear();
                txtDescripcionCateg.Clear();
                MessageBox.Show("Categoria agregada correctamente");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ ex.Message);
            }
        }
    }
}

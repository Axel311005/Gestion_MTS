using Gestion_MTS.Clases;
using Gestion_MTS.IRepository.Repository;
using Gestion_MTS.Vistas;
using Syncfusion.Windows.Forms;
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
        public int idSer;
        public int idCat;
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
        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateServ_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Servicio
                    {
                        IdServicio = idSer,
                        Nombre = txtNombreServ.Text,
                        Descripcion = txtDescripServ.Text,
                        IdCategoriaServicio = categoria.GetId(cboCategoria.Text)
                    };

                    servicio.Update(update, 0);
                    MessageBox.Show("Servicio actualizado correctamente");
                    Refresh();
                    txtDescripServ.Clear();
                    txtNombreServ.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el servicio " + ex.Message);
                }
            }
        }
        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (dgvCategoriaServicios.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new CategoriaServicio
                    {
                        IdCategoriaServicio = idCat,
                        Nombre = txtNombreCategoria.Text,
                        Descripcion = txtDescripcionCateg.Text,
                    };

                    categoria.Update(update, 0);
                    MessageBox.Show("Categoria actualizada correctamente");
                    Refresh();
                    txtNombreCategoria.Clear();
                    txtDescripcionCateg.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la categoria " + ex.Message);

                }
            }
        }
        private void btnDeleteServ_Click(object sender, EventArgs e)
        {
            if (dgvServicios.Rows.Count > 0)
            {

                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar el servicio '{txtNombreServ.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    servicio.Delete(idSer);
                    MessageBox.Show("¡Servicio eliminado exitosamente!", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    txtDescripServ.Clear();
                    txtNombreServ.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un servicio para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            if (dgvCategoriaServicios.Rows.Count > 0)
            {
                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar la categoria '{txtNombreCategoria.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    categoria.Delete(idCat);
                    MessageBox.Show("¡Categoria eliminada exitosamente!", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    txtNombreCategoria.Clear();
                    txtDescripcionCateg.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvServicios.Rows[e.RowIndex];

                VistaServicios ser = new VistaServicios
                {
                    nombre = row.Cells["nombre"].Value?.ToString(),
                    descripcion = row.Cells["descripcion"].Value?.ToString(),
                    categoria = row.Cells["categoria"].Value?.ToString(),
                };

                idSer = Convert.ToInt32(row.Cells["id_servicio"].Value);
                txtNombreServ.Text = ser.nombre;
                txtDescripServ.Text = ser.descripcion;
                cboCategoria.Text = ser.categoria;
            }
        }

        private void dgvCategoriaServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategoriaServicios.Rows[e.RowIndex];

                CategoriaServicio cate = new CategoriaServicio
                {
                    Nombre = row.Cells["nombre"].Value?.ToString(),
                    Descripcion = row.Cells["descripcion"].Value?.ToString(),
                };

                idCat = Convert.ToInt32(row.Cells["id_categoriaServicio"].Value);
                txtNombreCategoria.Text = cate.Nombre;
                txtDescripcionCateg.Text = cate.Descripcion;
            }
        }

        private void btnAddCateg_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}

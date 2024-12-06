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
using Gestion_MTS.Clases;
using Gestion_MTS.ConsultasAdo.Net;
using Gestion_MTS.IRepository.Repository;
using Gestion_MTS.Vistas;

namespace Gestion_MTS
{
    public partial class AdmonSucursales : Form
    {

        BodegaRepository bodega;
        LocalizacionEnBodegaRepository local;
        SucursalRepository sucursal;

        public int idLocal;
        public int idBod;
        public int idSuc;


        public AdmonSucursales()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            bodega = new BodegaRepository(connectionString);
            local = new LocalizacionEnBodegaRepository(connectionString);
            sucursal = new SucursalRepository(connectionString);
            
        }

        private void btnAddBodega_Click(object sender, EventArgs e)
        {

            
            try
            {
                int id_sucursal = Convert.ToInt32(sucursal.GetIdSucursal(cboSucursales.Text));
                Bodega bodegaa = new Bodega
                {
                    nombre = txtNombreBodegas.Text,
                    id_sucursal = id_sucursal
                };
                bodega.Add(bodegaa);
                cboBodegas.DataSource = bodega.GetAll();
                MessageBox.Show("Bodega agregada correctamente");
                txtNombreBodegas.Clear();
                Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar una bodega" + ex.Message);
            }

        }

        private void btnAddLocalBod_Click(object sender, EventArgs e)
        {
            //int id_bodegaa = Convert.ToInt32(bod.GetIdBodega(cboBodegas.Text));
            int id_bodega = Convert.ToInt32(bodega.GetIdBodega(cboBodegas.Text));

            MessageBox.Show("ID de bodega obtenido: " + id_bodega);




            //bod.AddLocalBodega(txtDescripcionLocalBod.Text, id_bodega);
            //MessageBox.Show("Localizacion en bodega agregada correctamente");
            try
            {
                LocalizacionEnBodega localizacion = new LocalizacionEnBodega
                {
                    descripcion = txtDescripcionLocalBod.Text,
                    id_bodega = id_bodega
                };
                local.Add(localizacion);
                Refresh();
                MessageBox.Show("Localizacion en bodega agregada correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar una localizacion en bodega" + ex.Message);
            }
        }

        private void btnAddSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                Sucursal newSucursal = new Sucursal
                {
                    ubicacion = txtUbiSucur.Text,
                    telefono = txtTelSucur.Text,
                };

                sucursal.Add(newSucursal);
                MessageBox.Show("Sucursal agregada correctamente");
                txtUbiSucur.Clear();
                txtTelSucur.Clear();
                Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Refresh()
        {
            dgvBodegas.DataSource = bodega.GetAll();
            dgvLocalBodega.DataSource = local.GetAll();
            dgvSucursales.DataSource = sucursal.GetAll();
            cboSucursales.DataSource = sucursal.GetUbicacionSucursal();
            cboBodegas.DataSource = bodega.GetNombreBodega();
        }

        private void AdmonSucursales_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnUpdateBodega_Click(object sender, EventArgs e)
        {
            if(dgvBodegas.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Bodega
                    {
                        id_bodega = idBod,
                        nombre = txtNombreBodegas.Text,
                        id_sucursal = Convert.ToInt32(sucursal.GetIdSucursal(cboSucursales.Text)),
                    };

                    bodega.Update(update, 0);
                    MessageBox.Show("Bodega actualizada correctamente");
                    Refresh();
                    txtNombreBodegas.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar " + ex.Message);
                }
            }
        }
        private void btnUpdateSucursal_Click(object sender, EventArgs e)
        {
            if (dgvSucursales.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Sucursal
                    {
                        id_sucursal = idSuc,
                        ubicacion = txtUbiSucur.Text,
                        telefono = txtTelSucur.Text
                    };

                    sucursal.Update(update, 0); 
                    Refresh();
                    MessageBox.Show("Sucursal actualizada correctamente");
                    txtUbiSucur.Clear();
                    txtTelSucur.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar " + ex.Message);
                }
            }
        }

        private void btnUpdateLocalBod_Click(object sender, EventArgs e)
        {
            if (dgvLocalBodega.SelectedRows.Count > 0)
            {
                try
                {
                    int id_bodega = Convert.ToInt32(bodega.GetIdBodega(cboBodegas.Text));
                    var update = new LocalizacionEnBodega
                    {
                        id_localizacionBodega = idLocal,
                        descripcion = txtDescripcionLocalBod.Text,
                        id_bodega = id_bodega
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar " + ex.Message);
                }
            }
        }
        private void btnDeleteBodega_Click(object sender, EventArgs e)
        {
            if(dgvBodegas.Rows.Count > 0)
            {
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar '{txtNombreBodegas.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bodega.Delete(idBod);
                        Refresh();
                        txtNombreBodegas.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteSucursal_Click(object sender, EventArgs e)
        {
            if (dgvSucursales.Rows.Count > 0)
            {
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar '{txtUbiSucur.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        sucursal.Delete(idSuc);
                        Refresh();
                        txtUbiSucur.Clear();
                        txtTelSucur.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnDeleteLocalBod_Click(object sender, EventArgs e)
        {
            if (dgvLocalBodega.Rows.Count > 0)
            {
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar '{txtDescripcionLocalBod.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        local.Delete(idLocal);
                        Refresh();
                        txtDescripcionLocalBod.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSucursales.Rows[e.RowIndex];
                Sucursal suc = new Sucursal
                {
                    ubicacion = row.Cells["ubicacion"]?.Value?.ToString(),
                    telefono = row.Cells["telefono"]?.Value?.ToString()
                };

                idSuc = Convert.ToInt32(row.Cells["id_sucursal"].Value);
                txtUbiSucur.Text = suc.ubicacion;
                txtTelSucur.Text = suc.telefono;
            }
        }

        private void dgvBodegas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBodegas.Rows[e.RowIndex];
                BodegasView bodegas = new BodegasView
                {
                    bodega = row.Cells["bodega"]?.Value?.ToString(),
                    sucursal = row.Cells["sucursal"]?.Value?.ToString(),
                };
                
                idBod = Convert.ToInt32(row.Cells["id_bodega"].Value);
                cboSucursales.Text = bodegas.sucursal;
                txtNombreBodegas.Text = bodegas.bodega;
            }
        }

        private void dgvLocalBodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLocalBodega.Rows[e.RowIndex];

                LocalizacionesBodegaView local = new LocalizacionesBodegaView
                {
                    descripcion = row.Cells["descripcion"]?.Value?.ToString(),
                    bodega = row.Cells["bodega"]?.Value?.ToString()
                };

                idLocal = Convert.ToInt32(row.Cells["id_localizacionBodega"].Value);
                cboBodegas.Text = local.bodega;
                txtDescripcionLocalBod.Text = local.descripcion;
            }
        }

        private void txtUbiSucur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtTelSucur_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreBodegas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtDescripcionLocalBod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

       
    }
}

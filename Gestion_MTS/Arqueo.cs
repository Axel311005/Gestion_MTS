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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_MTS
{
    public partial class Arqueo : Form
    {



        SucursalRepository sucursal;
        GastoRepository gasto;
        public int idGasto;
        public DateTime FechaGas;
        public Arqueo()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            sucursal = new SucursalRepository(connectionString);
            gasto = new GastoRepository(connectionString);

        }

        private void Arqueo_Load(object sender, EventArgs e)
        {

            Refresh();
        }

        public void Refresh()
        {
            cboSucursales.DataSource = sucursal.GetUbicacionSucursal();
            dgvGastos.DataSource = gasto.GetAll();
            cboSucursal.DataSource = sucursal.GetUbicacionSucursal(); 
        }

        private void ObtenerGastos_Click(object sender, EventArgs e)
        {
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void btnUpdateGasto_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteGasto_Click(object sender, EventArgs e)
        {

        }

        private void txtdescripgastos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtMontogasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            if (textBox.Text.Contains("."))
            {
                string[] parts = textBox.Text.Split('.');
                if (parts.Length > 1 && parts[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGastos.Rows[e.RowIndex];

                VistaGastos gast = new VistaGastos
                {
                    descripcion = row.Cells["descripcion"]?.Value?.ToString(),
                    monto = Convert.ToDecimal(row.Cells["monto"]?.Value?.ToString()),
                    sucursal = row.Cells["sucursal"]?.Value?.ToString(),
                    FechaGasto = Convert.ToDateTime(row.Cells["FechaGasto"]?.Value?.ToString())

                };
                idGasto = Convert.ToInt32(row.Cells["id_gasto"].Value);
                FechaGas = Convert.ToDateTime(row.Cells["FechaGasto"]?.Value?.ToString());
                txtdescripgastos.Text = gast.descripcion;
                txtMontogasto.Text = gast.monto.ToString();
                cboSucursal.Text = gast.sucursal;
            }
        }

        private void btnUpdateGasto_Click_1(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Gasto
                    {
                        IdGasto = idGasto,
                        descripcion = txtdescripgastos.Text,
                        monto = Convert.ToDecimal(txtMontogasto.Text),
                        IdSucursal = Convert.ToInt32(sucursal.GetIdSucursal(cboSucursal.Text)),
                        FechaGasto = FechaGas,

                    };

                    gasto.Update(update, 0);
                    MessageBox.Show("Gasto actualizado correctamente");
                    LimpiarText();
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar " + ex.Message);

                }
            }
        }

        private void btnDeleteGasto_Click_1(object sender, EventArgs e)
        {
            if (dgvGastos.Rows.Count > 0)
            {

                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        gasto.Delete(idGasto);
                        MessageBox.Show("¡Gasto eliminado exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        LimpiarText();
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show($"Error al eliminar gasto: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnAddGasto_Click(object sender, EventArgs e)
        {
            try
            {
                Gasto gast = new Gasto
                {
                    descripcion = txtdescripgastos.Text,
                    monto = Convert.ToDecimal(txtMontogasto.Text),
                    IdSucursal = Convert.ToInt32(sucursal.GetIdSucursal(cboSucursal.Text)),

                };

                gasto.Add(gast);
                MessageBox.Show("Gasto Agregado correctamente");
                LimpiarText();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el gasto " + ex.Message);
            }
        }

        private void LimpiarText()
        {
            txtdescripgastos.Clear();
            txtMontogasto.Clear();

        }

        private void ObtenerGastos_Click_1(object sender, EventArgs e)
        {
            int? suc = sucursal.GetIdSucursal(cboSucursales.Text);

            txtTotal.Text = gasto.CalcularMontoTotalGastosPorSucursal(dtpFechaInicio.Value,
                dtpFechaFinal.Value, suc).ToString();
        }
    }
}

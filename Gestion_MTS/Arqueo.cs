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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_MTS
{
    public partial class Arqueo : Form
    {


        ConsultasArqueoRepository arq = new ConsultasArqueoRepository();
        SucursalRepository sucursal;
        GastoRepository gasto;
        public Arqueo()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            sucursal = new SucursalRepository(connectionString);
            gasto = new GastoRepository(connectionString);

        }

        private void Arqueo_Load(object sender, EventArgs e)
        {
            cboSucursales.DataSource = sucursal.GetUbicacionSucursal();

        }

        private void ObtenerGastos_Click(object sender, EventArgs e)
        {
            int? suc = sucursal.GetIdSucursal(cboSucursales.Text);

            txtTotal.Text = gasto.CalcularMontoTotalGastosPorSucursal(dtpFechaInicio.Value,
                dtpFechaFinal.Value, suc).ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGasto_Click(object sender, EventArgs e)
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMontogasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            // Verificar que el carácter sea un dígito, un punto, o un carácter de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Verificar que solo se permita un punto decimal
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            // Restringir a dos dígitos después del punto decimal
            if (textBox.Text.Contains("."))
            {
                string[] parts = textBox.Text.Split('.');
                if (parts.Length > 1 && parts[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}

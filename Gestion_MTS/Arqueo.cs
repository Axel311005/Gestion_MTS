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
            
            txtTotal.Text = gasto.CalcularMontoTotalGastosPorSucursal(dtpFechaInicio.Value , 
                dtpFechaFinal.Value, suc).ToString();
            
            
        }
    }
}

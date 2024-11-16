using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_MTS.Clases;
using Gestion_MTS.ConsultasAdo.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_MTS
{
    public partial class Arqueo : Form
    {
        
        ConsultasAdmonBodegas bod = new ConsultasAdmonBodegas();
        ConsultasArqueo arq = new ConsultasArqueo();
        public Arqueo()
        {
            InitializeComponent();
        }

        private void Arqueo_Load(object sender, EventArgs e)
        {
            cbSucursales.DataSource = bod.GetSucursales();

        }

        private void ObtenerGastos_Click(object sender, EventArgs e)
        {
            string sucursal = cbSucursales.SelectedValue.ToString();
            
            dgvGastosDiarios.DataSource = arq.GetGastosPorSucursalYFecha(sucursal,dtpFechaFiltroGasto.Value);
        }
    }
}

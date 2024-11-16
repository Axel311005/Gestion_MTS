using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_MTS.ConsultasAdo.Net;

namespace Gestion_MTS
{
    public partial class AdmonSucursales : Form
    {
        DataBaseConnection db = new DataBaseConnection();
        ConsultasAdmonBodegas bod = new ConsultasAdmonBodegas();
        public AdmonSucursales()
        {
            InitializeComponent();
            cboSucursales.DataSource = bod.GetSucursales();
            cboBodegas.DataSource = bod.GetBodegas();
        }

        private void btnAddBodega_Click(object sender, EventArgs e)
        {


            try
            {
                int id_sucursal = Convert.ToInt32(bod.GetIdSucursal(cboSucursales.Text));
                bod.AddBodegas(txtNombreBodegas.Text, id_sucursal);
                cboBodegas.DataSource = bod.GetBodegas();
                MessageBox.Show("Bodega agregada correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar una bodega" + ex.Message);
            }

        }

        private void btnAddLocalBod_Click(object sender, EventArgs e)
        {
            int id_bodega = Convert.ToInt32(bod.GetIdBodega(cboBodegas.Text));


            MessageBox.Show("ID de bodega obtenido: " + id_bodega);


            bod.AddLocalBodega(txtDescripcionLocalBod.Text, id_bodega);
            MessageBox.Show("Localizacion en bodega agregada correctamente");
            try
            {
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar una localizacion en bodega" + ex.Message);
            }
        }
    }
}

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

namespace Gestion_MTS
{
    public partial class AdmonSucursales : Form
    {

        BodegaRepository bodega;
        LocalizacionEnBodegaRepository local;
        SucursalRepository sucursal;
        public AdmonSucursales()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            bodega = new BodegaRepository(connectionString);
            local = new LocalizacionEnBodegaRepository(connectionString);
            sucursal = new SucursalRepository(connectionString);
            cboSucursales.DataSource = sucursal.GetUbicacionSucursal();
            cboBodegas.DataSource = bodega.GetNombreBodega();
        }

        private void btnAddBodega_Click(object sender, EventArgs e)
        {

            //hecho anteriormente
            //try
            //{
            //    int id_sucursal = Convert.ToInt32(bod.GetIdSucursal(cboSucursales.Text));
            //    bod.AddBodegas(txtNombreBodegas.Text, id_sucursal);
            //    cboBodegas.DataSource = bod.GetBodegas();
            //    MessageBox.Show("Bodega agregada correctamente");

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error al agregar una bodega" + ex.Message);
            //}

            //nuevoooo
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
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AdmonSucursales_Load(object sender, EventArgs e)
        {
            dgvBodegas.DataSource = bodega.GetAll();
            dgvLocalBodega.DataSource = local.GetAll();
            dgvSucursales.DataSource = sucursal.GetAll();
        }
    }
}

using Gestion_MTS.Clases;
using Gestion_MTS.IRepository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_MTS
{
    public partial class Informacion_Adicional : Form
    {

        ClienteRepository cliente;
        TipoPagoRepository tipos;
        public int idClient;
        public int idTipo;

        public Informacion_Adicional()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            cliente = new ClienteRepository(connectionString);
            tipos = new TipoPagoRepository(connectionString);
        }

        public void Refresh()
        {
            dgvClientes.DataSource = cliente.GetAll();
            dgvTipoPago.DataSource = tipos.GetAll();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTipoDePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                Cliente clientes = new Cliente
                {
                    Nombre = row.Cells["nombre"]?.Value?.ToString(),
                    Apellido = row.Cells["apellido"]?.Value?.ToString(),
                    Direccion = row.Cells["direccion"]?.Value?.ToString(),
                };

                idClient = Convert.ToInt32(row.Cells["id_cliente"].Value);
                txtNombreCliente.Text = clientes.Nombre;
                txtApellidoCliente.Text = clientes.Apellido;
                txtDireccion.Text = clientes.Direccion;
            }
        }
        private void dgvTipoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTipoPago.Rows[e.RowIndex];
                TipoPago tip = new TipoPago
                {
                    Tipo = row.Cells["tipo"]?.Value?.ToString(),
                };
                idTipo = Convert.ToInt32(row.Cells["id_tipo_pago"].Value);
                txtTipoDePago.Text = tip.Tipo;
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clientes = new Cliente
                {
                    Nombre = txtNombreCliente.Text,
                    Apellido = txtApellidoCliente.Text,
                    Direccion = txtDireccion.Text 
                }; 

                cliente.Add(clientes);
                MessageBox.Show("Cliente Agregado correctamente");
                LimpiarTextCliente();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar " + ex.Message);
            }
        }

        private void LimpiarTextCliente()
        {
            txtDireccion.Clear();
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
        }

        private void btnAddTipo_Click(object sender, EventArgs e)
        {
            try
            {
                TipoPago pago = new TipoPago
                {
                    Tipo = txtTipoDePago.Text,
                };

                tipos.Add(pago);
                MessageBox.Show("Tipo de Pago Agregado correctamente");
                txtTipoDePago.Clear();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar " + ex.Message);
            }
        }

        private void btnUpdateCliente_Click(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Cliente
                    {
                        IdCliente = idClient,
                        Nombre = txtNombreCliente.Text,
                        Apellido = txtApellidoCliente.Text,
                        Direccion = txtDireccion.Text
                    };

                    cliente.Update(update, 0);
                    MessageBox.Show("Cliente actualizado correctamente");
                    LimpiarTextCliente();
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar " + ex.Message);
                }
            }
        }
        private void btnUpdateTipo_Click(object sender, EventArgs e)
        {
            if (dgvTipoPago.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new TipoPago
                    {
                        IdTipoPago = idTipo,
                        Tipo = txtTipoDePago.Text,
                    };

                    tipos.Update(update, 0);
                    MessageBox.Show("Tipo de Pago actualizado correctamente");
                    txtTipoDePago.Clear();
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar " + ex.Message);
                }
            }
        }
        private void btnDeleteCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar a '{txtNombreCliente.Text}'?",
                   "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        cliente.Delete(idClient);
                        Refresh();
                        LimpiarTextCliente();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar : {ex.Message}",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                
        }


        private void btnDeleteTipo_Click(object sender, EventArgs e)
        {
            if (dgvTipoPago.Rows.Count > 0)
            {
                var result = MessageBox.Show($"¿Está seguro de que desea eliminar  '{txtTipoDePago.Text}'?",
                   "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        tipos.Delete(idTipo);
                        Refresh();
                        txtTipoDePago.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar : {ex.Message}",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Informacion_Adicional_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}

using Gestion_MTS.IRepository.Repository;
using Gestion_MTS.Vistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Gestion_MTS
{
    public partial class ImprimirFactura : Form
    {
        private int IdFactura;
        private string _connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        private Bitmap fullBitmap;

        public ImprimirFactura(int IdFactura)
        {
            this.IdFactura = IdFactura;
            InitializeComponent();
        }

        private void ImprimirFactura_Load(object sender, EventArgs e)
        {
            FacturaRepository facturaRepo = new FacturaRepository(_connection);

            FacturaInfo? facturaInfo = facturaRepo.GetFacturaInfo(this.IdFactura);

            if (facturaInfo == null)
            {
                MessageBox.Show("No se encontro la factura especificada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblDate.Text = facturaInfo.fecha.ToString();
            lblFacturaNumber.Text = facturaInfo.numeroFactura.ToString();
            lblEmployeeName.Text = facturaInfo.empleado;
            lblPaymentType.Text = facturaInfo.tipoPago;
            lblClientName.Text = facturaInfo.cliente;

            List<FacturaProductInfo> facturaProducts = facturaRepo.GetFacturaProducts(this.IdFactura);
            List<FacturaServicesInfo> facturaServices = facturaRepo.GetFacturaServices(this.IdFactura);

            if (facturaProducts.Count != 0)
            {
                AddInfoToProductsSection(facturaProducts);
                grpServices.Top = grpProducts.Top + grpProducts.Height + 34;
            }

            if (facturaServices.Count != 0)
            {
                AddInfoToServicesSection(facturaServices);
                btnPrintFactura.Top = grpServices.Top + grpServices.Height + 8;
            }
        }

        private void AddInfoToProductsSection(List<FacturaProductInfo> products)
        {
            foreach ((FacturaProductInfo p, int idx) in products.Select((p, i) => (p, i)))
            {
                Label nameLabel = new Label
                {
                    Text = $"{p.nombre}",
                    Top = 40 * (idx + 1) + 36,
                    Left = 13,
                    AutoSize = true
                };

                Label priceLabel = new Label
                {
                    Text = $"{p.precioUnitario}",
                    Top = 40 * (idx + 1) + 36,
                    Left = 130,
                    AutoSize = true
                };

                Label quantityLabel = new Label
                {
                    Text = $"{p.cantidad}",
                    Top = 40 * (idx + 1) + 36,
                    Left = 223,
                    AutoSize = true
                };

                Label amountLabel = new Label
                {
                    Text = $"{p.monto}",
                    Top = 40 * (idx + 1) + 36,
                    Left = 335,
                    AutoSize = true
                };

                grpProducts.Controls.Add(nameLabel);
                grpProducts.Controls.Add(priceLabel);
                grpProducts.Controls.Add(quantityLabel);
                grpProducts.Controls.Add(amountLabel);
            }
        }

        private void AddInfoToServicesSection(List<FacturaServicesInfo> services)
        {
            foreach ((FacturaServicesInfo s, int idx) in services.Select((s, i) => (s, i)))
            {
                Label nameLabel = new Label
                {
                    Text = $"{s.nombre}",
                    Top = 40 * (idx + 1) + 36,
                    Left = 24,
                    AutoSize = true
                };

                Label amountLabel = new Label
                {
                    Text = $"{s.monto}",
                    Top = 40 * (idx + 1) + 36,
                    Left = 223,
                    AutoSize = true
                };

                grpServices.Controls.Add(nameLabel);
                grpServices.Controls.Add(amountLabel);
            }
        }

        private void btnPrintFactura_Click(object sender, EventArgs e)
        {
            var originalSize = pnlWrapper.Size;

            pnlWrapper.Size = pnlWrapper.AutoScrollMinSize;
            btnPrintFactura.Visible = false;

            try
            {

                CaptureFormBitmap();

                if(printDialogFactura.ShowDialog() == DialogResult.OK)
                {
                    printFactura.Print();
                }

            } finally
            {
                btnPrintFactura.Visible = true;
                pnlWrapper.Size = originalSize;
            }
        }

        private void printFactura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float scaleX = (float)e.PageBounds.Width / fullBitmap.Width;
            float scaleY = (float)e.PageBounds.Height / fullBitmap.Height;
            float scale = Math.Min(scaleX, scaleY);

            int scaledWidth = (int)(fullBitmap.Width * scale);
            int scaledHeight = (int)(fullBitmap.Height * scale);

            // Draw the bitmap onto the print document
            e.Graphics.DrawImage(fullBitmap, 0, 0, scaledWidth, scaledHeight);
        }

        private void CaptureFormBitmap()
        {
            // Create a bitmap of the form
            fullBitmap = new Bitmap(pnlWrapper.Width, pnlWrapper.Height);
            this.DrawToBitmap(fullBitmap, new Rectangle(0, 0, pnlWrapper.Width, pnlWrapper.Height));
        }
    }
}

namespace Gestion_MTS
{
    partial class ImprimirFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirFactura));
            pnlWrapper = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblTotal = new Label();
            lblIva = new Label();
            lblSubtotal = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnPrintFactura = new Button();
            grpServices = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            grpProducts = new GroupBox();
            lblAmountHeader = new Label();
            lblQuantityHeader = new Label();
            lblPriceHeader = new Label();
            lblNameHeader = new Label();
            lblFacturaNumber = new Label();
            lblNumeroFactura = new Label();
            lblPaymentType = new Label();
            lblPago = new Label();
            lblClientName = new Label();
            lblEmployeeName = new Label();
            lblCliente = new Label();
            lblAtendido = new Label();
            lblDate = new Label();
            mtsLogo = new PictureBox();
            printFactura = new System.Drawing.Printing.PrintDocument();
            printDialogFactura = new PrintDialog();
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            pnlWrapper.SuspendLayout();
            grpServices.SuspendLayout();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mtsLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlWrapper
            // 
            pnlWrapper.AutoScroll = true;
            pnlWrapper.Controls.Add(label13);
            pnlWrapper.Controls.Add(label12);
            pnlWrapper.Controls.Add(label11);
            pnlWrapper.Controls.Add(label10);
            pnlWrapper.Controls.Add(label9);
            pnlWrapper.Controls.Add(label8);
            pnlWrapper.Controls.Add(label7);
            pnlWrapper.Controls.Add(label6);
            pnlWrapper.Controls.Add(lblTotal);
            pnlWrapper.Controls.Add(lblIva);
            pnlWrapper.Controls.Add(lblSubtotal);
            pnlWrapper.Controls.Add(label5);
            pnlWrapper.Controls.Add(label3);
            pnlWrapper.Controls.Add(label2);
            pnlWrapper.Controls.Add(btnPrintFactura);
            pnlWrapper.Controls.Add(grpServices);
            pnlWrapper.Controls.Add(grpProducts);
            pnlWrapper.Controls.Add(lblFacturaNumber);
            pnlWrapper.Controls.Add(lblNumeroFactura);
            pnlWrapper.Controls.Add(lblPaymentType);
            pnlWrapper.Controls.Add(lblPago);
            pnlWrapper.Controls.Add(lblClientName);
            pnlWrapper.Controls.Add(lblEmployeeName);
            pnlWrapper.Controls.Add(lblCliente);
            pnlWrapper.Controls.Add(lblAtendido);
            pnlWrapper.Controls.Add(lblDate);
            pnlWrapper.Controls.Add(mtsLogo);
            pnlWrapper.Dock = DockStyle.Fill;
            pnlWrapper.Location = new Point(0, 0);
            pnlWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlWrapper.Name = "pnlWrapper";
            pnlWrapper.Size = new Size(738, 822);
            pnlWrapper.TabIndex = 0;
            pnlWrapper.Paint += pnlWrapper_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(604, 155);
            label13.Name = "label13";
            label13.Size = new Size(87, 24);
            label13.TabIndex = 39;
            label13.Text = "FACTURA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold);
            label12.Location = new Point(351, 157);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 38;
            label12.Text = "Tel.: 2252-5148";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold);
            label11.Location = new Point(297, 139);
            label11.Name = "label11";
            label11.Size = new Size(190, 15);
            label11.TabIndex = 37;
            label11.Text = "1c. al lago, 1c. abajo, Managua, Nic";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold);
            label10.Location = new Point(254, 122);
            label10.Name = "label10";
            label10.Size = new Size(260, 15);
            label10.TabIndex = 36;
            label10.Text = "Dir.:Barrio El Riguero, de los Talleres Modernos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold);
            label9.Location = new Point(322, 81);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 35;
            label9.Text = "RUC: J0910000261625";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold);
            label8.Location = new Point(227, 64);
            label8.Name = "label8";
            label8.Size = new Size(321, 15);
            label8.TabIndex = 34;
            label8.Text = "Reparación, Ventas de Repuestos y Accesorios para motos";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 7.20000029F, FontStyle.Bold);
            label7.Location = new Point(297, 47);
            label7.Name = "label7";
            label7.Size = new Size(172, 15);
            label7.TabIndex = 33;
            label7.Text = "TERRY RODRIGUEZ Y CIA, LTDA.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(243, 9);
            label6.Name = "label6";
            label6.Size = new Size(296, 35);
            label6.TabIndex = 32;
            label6.Text = "MOTO SERVICIOS TERRY";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Calibri", 7.8F);
            lblTotal.Location = new Point(563, 750);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 15);
            lblTotal.TabIndex = 31;
            lblTotal.Text = "label6";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Font = new Font("Calibri", 7.8F);
            lblIva.Location = new Point(563, 722);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(42, 15);
            lblIva.TabIndex = 30;
            lblIva.Text = "label7";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Calibri", 7.8F);
            lblSubtotal.Location = new Point(563, 694);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(42, 15);
            lblSubtotal.TabIndex = 29;
            lblSubtotal.Text = "label8";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 7.8F);
            label5.Location = new Point(60, 750);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 28;
            label5.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 7.8F);
            label3.Location = new Point(60, 722);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 27;
            label3.Text = "15% IVA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 7.8F);
            label2.Location = new Point(60, 694);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 26;
            label2.Text = "Subtotal";
            label2.Click += label2_Click;
            // 
            // btnPrintFactura
            // 
            btnPrintFactura.BackColor = Color.FromArgb(255, 128, 0);
            btnPrintFactura.Dock = DockStyle.Bottom;
            btnPrintFactura.FlatStyle = FlatStyle.Flat;
            btnPrintFactura.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintFactura.ForeColor = SystemColors.ButtonHighlight;
            btnPrintFactura.Location = new Point(0, 767);
            btnPrintFactura.Margin = new Padding(3, 4, 3, 4);
            btnPrintFactura.Name = "btnPrintFactura";
            btnPrintFactura.Size = new Size(738, 55);
            btnPrintFactura.TabIndex = 25;
            btnPrintFactura.Text = "Imprimir Factura";
            btnPrintFactura.UseVisualStyleBackColor = false;
            btnPrintFactura.Click += btnPrintFactura_Click;
            // 
            // grpServices
            // 
            grpServices.AutoSize = true;
            grpServices.Controls.Add(label1);
            grpServices.Controls.Add(label4);
            grpServices.Font = new Font("Calibri", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpServices.Location = new Point(45, 486);
            grpServices.Margin = new Padding(3, 4, 3, 4);
            grpServices.Name = "grpServices";
            grpServices.Padding = new Padding(3, 4, 3, 4);
            grpServices.Size = new Size(614, 153);
            grpServices.TabIndex = 24;
            grpServices.TabStop = false;
            grpServices.Text = "Servicios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 48);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 48);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // grpProducts
            // 
            grpProducts.AutoSize = true;
            grpProducts.Controls.Add(lblAmountHeader);
            grpProducts.Controls.Add(lblQuantityHeader);
            grpProducts.Controls.Add(lblPriceHeader);
            grpProducts.Controls.Add(lblNameHeader);
            grpProducts.Font = new Font("Calibri", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProducts.Location = new Point(45, 268);
            grpProducts.Margin = new Padding(3, 4, 3, 40);
            grpProducts.Name = "grpProducts";
            grpProducts.Padding = new Padding(3, 4, 3, 4);
            grpProducts.Size = new Size(614, 153);
            grpProducts.TabIndex = 23;
            grpProducts.TabStop = false;
            grpProducts.Text = "Productos";
            // 
            // lblAmountHeader
            // 
            lblAmountHeader.AutoSize = true;
            lblAmountHeader.Location = new Point(518, 48);
            lblAmountHeader.Name = "lblAmountHeader";
            lblAmountHeader.Size = new Size(43, 15);
            lblAmountHeader.TabIndex = 3;
            lblAmountHeader.Text = "Monto";
            // 
            // lblQuantityHeader
            // 
            lblQuantityHeader.AutoSize = true;
            lblQuantityHeader.Location = new Point(351, 48);
            lblQuantityHeader.Name = "lblQuantityHeader";
            lblQuantityHeader.Size = new Size(56, 15);
            lblQuantityHeader.TabIndex = 2;
            lblQuantityHeader.Text = "Cantidad";
            // 
            // lblPriceHeader
            // 
            lblPriceHeader.AutoSize = true;
            lblPriceHeader.Location = new Point(198, 48);
            lblPriceHeader.Name = "lblPriceHeader";
            lblPriceHeader.Size = new Size(26, 15);
            lblPriceHeader.TabIndex = 1;
            lblPriceHeader.Text = "P/U";
            // 
            // lblNameHeader
            // 
            lblNameHeader.AutoSize = true;
            lblNameHeader.Location = new Point(15, 48);
            lblNameHeader.Name = "lblNameHeader";
            lblNameHeader.Size = new Size(50, 15);
            lblNameHeader.TabIndex = 0;
            lblNameHeader.Text = "Nombre";
            // 
            // lblFacturaNumber
            // 
            lblFacturaNumber.AutoSize = true;
            lblFacturaNumber.Font = new Font("Calibri", 7.8F);
            lblFacturaNumber.Location = new Point(649, 195);
            lblFacturaNumber.Name = "lblFacturaNumber";
            lblFacturaNumber.Size = new Size(35, 15);
            lblFacturaNumber.TabIndex = 22;
            lblFacturaNumber.Text = "label";
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.AutoSize = true;
            lblNumeroFactura.Font = new Font("Calibri", 7.8F);
            lblNumeroFactura.Location = new Point(604, 194);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(31, 15);
            lblNumeroFactura.TabIndex = 21;
            lblNumeroFactura.Text = "No : ";
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Font = new Font("Calibri", 7.8F);
            lblPaymentType.Location = new Point(151, 238);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(42, 15);
            lblPaymentType.TabIndex = 20;
            lblPaymentType.Text = "label2";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Calibri", 7.8F);
            lblPago.Location = new Point(50, 238);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(77, 15);
            lblPago.TabIndex = 19;
            lblPago.Text = "Tipo de Pago";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Calibri", 7.8F);
            lblClientName.Location = new Point(151, 214);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(42, 15);
            lblClientName.TabIndex = 18;
            lblClientName.Text = "label2";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Calibri", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(160, 155);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(42, 15);
            lblEmployeeName.TabIndex = 17;
            lblEmployeeName.Text = "label1";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Calibri", 7.8F);
            lblCliente.Location = new Point(50, 214);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(51, 15);
            lblCliente.TabIndex = 16;
            lblCliente.Text = "Cliente :";
            // 
            // lblAtendido
            // 
            lblAtendido.AutoSize = true;
            lblAtendido.Font = new Font("Calibri", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtendido.Location = new Point(30, 155);
            lblAtendido.Name = "lblAtendido";
            lblAtendido.Size = new Size(84, 15);
            lblAtendido.TabIndex = 15;
            lblAtendido.Text = "Atendido por :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Calibri", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(604, 215);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(14, 15);
            lblDate.TabIndex = 14;
            lblDate.Text = "h";
            // 
            // mtsLogo
            // 
            mtsLogo.Image = (Image)resources.GetObject("mtsLogo.Image");
            mtsLogo.Location = new Point(-16, -72);
            mtsLogo.Margin = new Padding(3, 4, 3, 4);
            mtsLogo.Name = "mtsLogo";
            mtsLogo.Size = new Size(253, 284);
            mtsLogo.SizeMode = PictureBoxSizeMode.Zoom;
            mtsLogo.TabIndex = 13;
            mtsLogo.TabStop = false;
            // 
            // printFactura
            // 
            printFactura.PrintPage += printFactura_PrintPage;
            // 
            // printDialogFactura
            // 
            printDialogFactura.Document = printFactura;
            printDialogFactura.UseEXDialog = true;
            // 
            // ImprimirFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 822);
            Controls.Add(pnlWrapper);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImprimirFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImprimirFactura";
            Load += ImprimirFactura_Load;
            pnlWrapper.ResumeLayout(false);
            pnlWrapper.PerformLayout();
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mtsLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWrapper;
        private GroupBox grpServices;
        private Label label1;
        private Label label4;
        private GroupBox grpProducts;
        private Label lblAmountHeader;
        private Label lblQuantityHeader;
        private Label lblPriceHeader;
        private Label lblNameHeader;
        private Label lblFacturaNumber;
        private Label lblNumeroFactura;
        private Label lblPaymentType;
        private Label lblPago;
        private Label lblClientName;
        private Label lblEmployeeName;
        private Label lblCliente;
        private Label lblAtendido;
        private Label lblDate;
        private PictureBox mtsLogo;
        private Button btnPrintFactura;
        private System.Drawing.Printing.PrintDocument printFactura;
        private PrintDialog printDialogFactura;
        private Label lblTotal;
        private Label lblIva;
        private Label lblSubtotal;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Label label13;
    }
}
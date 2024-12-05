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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirFactura));
            pnlWrapper = new Panel();
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
            pnlWrapper.SuspendLayout();
            grpServices.SuspendLayout();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mtsLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlWrapper
            // 
            pnlWrapper.AutoScroll = true;
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
            pnlWrapper.Name = "pnlWrapper";
            pnlWrapper.Size = new Size(460, 516);
            pnlWrapper.TabIndex = 0;
            // 
            // grpServices
            // 
            grpServices.AutoSize = true;
            grpServices.Controls.Add(label1);
            grpServices.Controls.Add(label4);
            grpServices.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpServices.Location = new Point(39, 349);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(368, 115);
            grpServices.TabIndex = 24;
            grpServices.TabStop = false;
            grpServices.Text = "Servicios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 36);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 3;
            label1.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 36);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
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
            grpProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProducts.Location = new Point(39, 201);
            grpProducts.Margin = new Padding(3, 3, 3, 30);
            grpProducts.Name = "grpProducts";
            grpProducts.Size = new Size(368, 115);
            grpProducts.TabIndex = 23;
            grpProducts.TabStop = false;
            grpProducts.Text = "Productos";
            // 
            // lblAmountHeader
            // 
            lblAmountHeader.AutoSize = true;
            lblAmountHeader.Location = new Point(293, 36);
            lblAmountHeader.Name = "lblAmountHeader";
            lblAmountHeader.Size = new Size(56, 21);
            lblAmountHeader.TabIndex = 3;
            lblAmountHeader.Text = "Monto";
            // 
            // lblQuantityHeader
            // 
            lblQuantityHeader.AutoSize = true;
            lblQuantityHeader.Location = new Point(195, 36);
            lblQuantityHeader.Name = "lblQuantityHeader";
            lblQuantityHeader.Size = new Size(72, 21);
            lblQuantityHeader.TabIndex = 2;
            lblQuantityHeader.Text = "Cantidad";
            // 
            // lblPriceHeader
            // 
            lblPriceHeader.AutoSize = true;
            lblPriceHeader.Location = new Point(114, 36);
            lblPriceHeader.Name = "lblPriceHeader";
            lblPriceHeader.Size = new Size(36, 21);
            lblPriceHeader.TabIndex = 1;
            lblPriceHeader.Text = "P/U";
            // 
            // lblNameHeader
            // 
            lblNameHeader.AutoSize = true;
            lblNameHeader.Location = new Point(13, 36);
            lblNameHeader.Name = "lblNameHeader";
            lblNameHeader.Size = new Size(68, 21);
            lblNameHeader.TabIndex = 0;
            lblNameHeader.Text = "Nombre";
            // 
            // lblFacturaNumber
            // 
            lblFacturaNumber.AutoSize = true;
            lblFacturaNumber.Font = new Font("Segoe UI", 12F);
            lblFacturaNumber.Location = new Point(379, 63);
            lblFacturaNumber.Name = "lblFacturaNumber";
            lblFacturaNumber.Size = new Size(43, 21);
            lblFacturaNumber.TabIndex = 22;
            lblFacturaNumber.Text = "label";
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.AutoSize = true;
            lblNumeroFactura.Font = new Font("Segoe UI", 12F);
            lblNumeroFactura.Location = new Point(249, 63);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(133, 21);
            lblNumeroFactura.TabIndex = 21;
            lblNumeroFactura.Text = "Numero Factura : ";
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Font = new Font("Segoe UI", 12F);
            lblPaymentType.Location = new Point(302, 150);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(52, 21);
            lblPaymentType.TabIndex = 20;
            lblPaymentType.Text = "label2";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 12F);
            lblPago.Location = new Point(276, 116);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(99, 21);
            lblPago.TabIndex = 19;
            lblPago.Text = "Tipo de Pago";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Segoe UI", 12F);
            lblClientName.Location = new Point(97, 150);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(52, 21);
            lblClientName.TabIndex = 18;
            lblClientName.Text = "label2";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(140, 116);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(52, 21);
            lblEmployeeName.TabIndex = 17;
            lblEmployeeName.Text = "label1";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F);
            lblCliente.Location = new Point(26, 150);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 21);
            lblCliente.TabIndex = 16;
            lblCliente.Text = "Cliente :";
            // 
            // lblAtendido
            // 
            lblAtendido.AutoSize = true;
            lblAtendido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtendido.Location = new Point(26, 116);
            lblAtendido.Name = "lblAtendido";
            lblAtendido.Size = new Size(108, 21);
            lblAtendido.TabIndex = 15;
            lblAtendido.Text = "Atendido por :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(261, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(19, 21);
            lblDate.TabIndex = 14;
            lblDate.Text = "h";
            // 
            // mtsLogo
            // 
            mtsLogo.Image = (Image)resources.GetObject("mtsLogo.Image");
            mtsLogo.Location = new Point(-14, -54);
            mtsLogo.Name = "mtsLogo";
            mtsLogo.Size = new Size(221, 213);
            mtsLogo.SizeMode = PictureBoxSizeMode.Zoom;
            mtsLogo.TabIndex = 13;
            mtsLogo.TabStop = false;
            // 
            // ImprimirFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 516);
            Controls.Add(pnlWrapper);
            Name = "ImprimirFactura";
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
    }
}
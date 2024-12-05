namespace Gestion_MTS
{
    partial class Facturas
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
            label1 = new Label();
            grpProducts = new GroupBox();
            btnDeleteRequestedProduct = new Button();
            btnUpdateRequestedProduct = new Button();
            btnAddProduct = new Button();
            lblAddedProducts = new Label();
            dgvProducts = new DataGridView();
            txtProductQuantity = new TextBox();
            lblQuantity = new Label();
            cmbProducts = new ComboBox();
            lblProduct = new Label();
            grpServices = new GroupBox();
            btnAddService = new Button();
            btnDeleteRequestedService = new Button();
            btnUpdateRequestedService = new Button();
            lblAddedServices = new Label();
            dgvServices = new DataGridView();
            txtAmount = new TextBox();
            lblAmount = new Label();
            cmbEmpleados = new ComboBox();
            lblEmployee = new Label();
            cmbServicios = new ComboBox();
            lblService = new Label();
            grpInfo = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cmbTipoPago = new ComboBox();
            lblTipoPago = new Label();
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            btnGenerateFactura = new Button();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            grpInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(292, 35);
            label1.Name = "label1";
            label1.Size = new Size(249, 22);
            label1.TabIndex = 0;
            label1.Text = "Elaboracion de Facturas";
            // 
            // grpProducts
            // 
            grpProducts.Anchor = AnchorStyles.None;
            grpProducts.Controls.Add(btnDeleteRequestedProduct);
            grpProducts.Controls.Add(btnUpdateRequestedProduct);
            grpProducts.Controls.Add(btnAddProduct);
            grpProducts.Controls.Add(lblAddedProducts);
            grpProducts.Controls.Add(dgvProducts);
            grpProducts.Controls.Add(txtProductQuantity);
            grpProducts.Controls.Add(lblQuantity);
            grpProducts.Controls.Add(cmbProducts);
            grpProducts.Controls.Add(lblProduct);
            grpProducts.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            grpProducts.Location = new Point(47, 98);
            grpProducts.Name = "grpProducts";
            grpProducts.Size = new Size(815, 145);
            grpProducts.TabIndex = 1;
            grpProducts.TabStop = false;
            grpProducts.Text = "Productos";
            // 
            // btnDeleteRequestedProduct
            // 
            btnDeleteRequestedProduct.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteRequestedProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteRequestedProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteRequestedProduct.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteRequestedProduct.Location = new Point(277, 83);
            btnDeleteRequestedProduct.Name = "btnDeleteRequestedProduct";
            btnDeleteRequestedProduct.Size = new Size(136, 23);
            btnDeleteRequestedProduct.TabIndex = 8;
            btnDeleteRequestedProduct.Text = "Eliminar Pedido";
            btnDeleteRequestedProduct.UseVisualStyleBackColor = false;
            btnDeleteRequestedProduct.Click += btnDeleteRequestedProduct_Click;
            // 
            // btnUpdateRequestedProduct
            // 
            btnUpdateRequestedProduct.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateRequestedProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateRequestedProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateRequestedProduct.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateRequestedProduct.Location = new Point(277, 38);
            btnUpdateRequestedProduct.Name = "btnUpdateRequestedProduct";
            btnUpdateRequestedProduct.Size = new Size(136, 23);
            btnUpdateRequestedProduct.TabIndex = 7;
            btnUpdateRequestedProduct.Text = "Actualizar Pedido";
            btnUpdateRequestedProduct.UseVisualStyleBackColor = false;
            btnUpdateRequestedProduct.Click += btnUpdateRequestedProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(255, 128, 0);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = SystemColors.ButtonHighlight;
            btnAddProduct.Location = new Point(15, 116);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(136, 23);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Agregar Producto";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblAddedProducts
            // 
            lblAddedProducts.AutoSize = true;
            lblAddedProducts.Location = new Point(572, 19);
            lblAddedProducts.Name = "lblAddedProducts";
            lblAddedProducts.Size = new Size(128, 13);
            lblAddedProducts.TabIndex = 5;
            lblAddedProducts.Text = "Productos Agregados";
            lblAddedProducts.Click += lblAddedProducts_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(476, 39);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(333, 100);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(81, 80);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(100, 19);
            txtProductQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(19, 83);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(57, 13);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Cantidad";
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(81, 35);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(121, 21);
            cmbProducts.TabIndex = 1;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(19, 38);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(58, 13);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Producto";
            // 
            // grpServices
            // 
            grpServices.Anchor = AnchorStyles.None;
            grpServices.Controls.Add(btnAddService);
            grpServices.Controls.Add(btnDeleteRequestedService);
            grpServices.Controls.Add(btnUpdateRequestedService);
            grpServices.Controls.Add(lblAddedServices);
            grpServices.Controls.Add(dgvServices);
            grpServices.Controls.Add(txtAmount);
            grpServices.Controls.Add(lblAmount);
            grpServices.Controls.Add(cmbEmpleados);
            grpServices.Controls.Add(lblEmployee);
            grpServices.Controls.Add(cmbServicios);
            grpServices.Controls.Add(lblService);
            grpServices.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            grpServices.Location = new Point(47, 278);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(815, 153);
            grpServices.TabIndex = 2;
            grpServices.TabStop = false;
            grpServices.Text = "Servicios";
            // 
            // btnAddService
            // 
            btnAddService.BackColor = Color.FromArgb(255, 128, 0);
            btnAddService.FlatStyle = FlatStyle.Flat;
            btnAddService.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddService.ForeColor = SystemColors.ButtonHighlight;
            btnAddService.Location = new Point(19, 124);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(136, 23);
            btnAddService.TabIndex = 14;
            btnAddService.Text = "Agregar Servicio";
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnDeleteRequestedService
            // 
            btnDeleteRequestedService.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteRequestedService.FlatStyle = FlatStyle.Flat;
            btnDeleteRequestedService.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteRequestedService.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteRequestedService.Location = new Point(277, 81);
            btnDeleteRequestedService.Name = "btnDeleteRequestedService";
            btnDeleteRequestedService.Size = new Size(136, 23);
            btnDeleteRequestedService.TabIndex = 13;
            btnDeleteRequestedService.Text = "Eliminar Pedido";
            btnDeleteRequestedService.UseVisualStyleBackColor = false;
            btnDeleteRequestedService.Click += btnDeleteRequestedService_Click;
            // 
            // btnUpdateRequestedService
            // 
            btnUpdateRequestedService.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateRequestedService.FlatStyle = FlatStyle.Flat;
            btnUpdateRequestedService.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateRequestedService.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateRequestedService.Location = new Point(277, 36);
            btnUpdateRequestedService.Name = "btnUpdateRequestedService";
            btnUpdateRequestedService.Size = new Size(136, 23);
            btnUpdateRequestedService.TabIndex = 12;
            btnUpdateRequestedService.Text = "Actualizar Pedido";
            btnUpdateRequestedService.UseVisualStyleBackColor = false;
            btnUpdateRequestedService.Click += btnUpdateRequestedService_Click;
            // 
            // lblAddedServices
            // 
            lblAddedServices.AutoSize = true;
            lblAddedServices.Location = new Point(580, 19);
            lblAddedServices.Name = "lblAddedServices";
            lblAddedServices.Size = new Size(123, 13);
            lblAddedServices.TabIndex = 11;
            lblAddedServices.Text = "Servicios Agregados";
            // 
            // dgvServices
            // 
            dgvServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = SystemColors.ButtonHighlight;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(482, 39);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(327, 108);
            dgvServices.TabIndex = 10;
            dgvServices.CellClick += dgvServices_CellClick;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(81, 94);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 19);
            txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(19, 97);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(42, 13);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Monto";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(81, 65);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(121, 21);
            cmbEmpleados.TabIndex = 7;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(15, 68);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(62, 13);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Empleado";
            // 
            // cmbServicios
            // 
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(81, 36);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(121, 21);
            cmbServicios.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(19, 39);
            lblService.Name = "lblService";
            lblService.Size = new Size(53, 13);
            lblService.TabIndex = 4;
            lblService.Text = "Servicio";
            // 
            // grpInfo
            // 
            grpInfo.Anchor = AnchorStyles.None;
            grpInfo.Controls.Add(label2);
            grpInfo.Controls.Add(label3);
            grpInfo.Location = new Point(40, 458);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(270, 100);
            grpInfo.TabIndex = 3;
            grpInfo.TabStop = false;
            grpInfo.Text = "Informacion Adicional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 10;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 34);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Pago";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(cmbTipoPago);
            groupBox1.Controls.Add(lblTipoPago);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            groupBox1.Location = new Point(47, 446);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Adicional";
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(96, 54);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(121, 21);
            cmbTipoPago.TabIndex = 11;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(7, 57);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(83, 13);
            lblTipoPago.TabIndex = 10;
            lblTipoPago.Text = "Tipo de Pago";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(73, 25);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 21);
            cmbCliente.TabIndex = 9;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(11, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(46, 13);
            lblCliente.TabIndex = 8;
            lblCliente.Text = "Cliente";
            // 
            // btnGenerateFactura
            // 
            btnGenerateFactura.Anchor = AnchorStyles.None;
            btnGenerateFactura.BackColor = Color.FromArgb(255, 128, 0);
            btnGenerateFactura.FlatStyle = FlatStyle.Flat;
            btnGenerateFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateFactura.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateFactura.Location = new Point(444, 489);
            btnGenerateFactura.Name = "btnGenerateFactura";
            btnGenerateFactura.Size = new Size(412, 57);
            btnGenerateFactura.TabIndex = 14;
            btnGenerateFactura.Text = "Generar Factura";
            btnGenerateFactura.UseVisualStyleBackColor = false;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 562);
            Controls.Add(btnGenerateFactura);
            Controls.Add(groupBox1);
            Controls.Add(grpServices);
            Controls.Add(grpProducts);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Facturas";
            Text = "Gestión Facturas";
            Load += Facturas_Load;
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpProducts;
        private ComboBox cmbProducts;
        private Label lblProduct;
        private GroupBox grpServices;
        private TextBox txtProductQuantity;
        private Label lblQuantity;
        private Label lblEmployee;
        private ComboBox cmbServicios;
        private Label lblService;
        private Label lblAmount;
        private ComboBox cmbEmpleados;
        private DataGridView dgvProducts;
        private Label lblAddedProducts;
        private Label lblAddedServices;
        private DataGridView dgvServices;
        private Button btnDeleteRequestedProduct;
        private Button btnUpdateRequestedProduct;
        private Button btnAddProduct;
        private Button btnAddService;
        private Button btnDeleteRequestedService;
        private Button btnUpdateRequestedService;
        private TextBox txtAmount;
        private GroupBox grpInfo;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox cmbTipoPago;
        private Label lblTipoPago;
        private ComboBox cmbCliente;
        private Label lblCliente;
        private Button btnGenerateFactura;
    }
}
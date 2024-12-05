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
            cmbCliente = new ComboBox();
            label2 = new Label();
            cmbTipoPago = new ComboBox();
            label3 = new Label();
            btnGenerateFactura = new Button();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 36);
            label1.Name = "label1";
            label1.Size = new Size(238, 24);
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
            grpProducts.Location = new Point(40, 89);
            grpProducts.Name = "grpProducts";
            grpProducts.Size = new Size(815, 145);
            grpProducts.TabIndex = 1;
            grpProducts.TabStop = false;
            grpProducts.Text = "Productos";
            // 
            // btnDeleteRequestedProduct
            // 
            btnDeleteRequestedProduct.Location = new Point(277, 83);
            btnDeleteRequestedProduct.Name = "btnDeleteRequestedProduct";
            btnDeleteRequestedProduct.Size = new Size(108, 23);
            btnDeleteRequestedProduct.TabIndex = 8;
            btnDeleteRequestedProduct.Text = "Eliminar Pedido";
            btnDeleteRequestedProduct.UseVisualStyleBackColor = true;
            btnDeleteRequestedProduct.Click += btnDeleteRequestedProduct_Click;
            // 
            // btnUpdateRequestedProduct
            // 
            btnUpdateRequestedProduct.Location = new Point(277, 38);
            btnUpdateRequestedProduct.Name = "btnUpdateRequestedProduct";
            btnUpdateRequestedProduct.Size = new Size(108, 23);
            btnUpdateRequestedProduct.TabIndex = 7;
            btnUpdateRequestedProduct.Text = "Actualizar Pedido";
            btnUpdateRequestedProduct.UseVisualStyleBackColor = true;
            btnUpdateRequestedProduct.Click += btnUpdateRequestedProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(15, 116);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(187, 23);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Agregar Producto";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblAddedProducts
            // 
            lblAddedProducts.AutoSize = true;
            lblAddedProducts.Location = new Point(572, 19);
            lblAddedProducts.Name = "lblAddedProducts";
            lblAddedProducts.Size = new Size(121, 15);
            lblAddedProducts.TabIndex = 5;
            lblAddedProducts.Text = "Productos Agregados";
            lblAddedProducts.Click += lblAddedProducts_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(476, 39);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(333, 100);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(81, 80);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(100, 23);
            txtProductQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(19, 83);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(55, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Cantidad";
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(81, 35);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(121, 23);
            cmbProducts.TabIndex = 1;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(19, 38);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(56, 15);
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
            grpServices.Location = new Point(40, 269);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(815, 153);
            grpServices.TabIndex = 2;
            grpServices.TabStop = false;
            grpServices.Text = "Servicios";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(19, 124);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(183, 23);
            btnAddService.TabIndex = 14;
            btnAddService.Text = "Agregar Servicio";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnDeleteRequestedService
            // 
            btnDeleteRequestedService.Location = new Point(277, 81);
            btnDeleteRequestedService.Name = "btnDeleteRequestedService";
            btnDeleteRequestedService.Size = new Size(108, 23);
            btnDeleteRequestedService.TabIndex = 13;
            btnDeleteRequestedService.Text = "Eliminar Pedido";
            btnDeleteRequestedService.UseVisualStyleBackColor = true;
            btnDeleteRequestedService.Click += btnDeleteRequestedService_Click;
            // 
            // btnUpdateRequestedService
            // 
            btnUpdateRequestedService.Location = new Point(277, 36);
            btnUpdateRequestedService.Name = "btnUpdateRequestedService";
            btnUpdateRequestedService.Size = new Size(108, 23);
            btnUpdateRequestedService.TabIndex = 12;
            btnUpdateRequestedService.Text = "ActualizarPedido";
            btnUpdateRequestedService.UseVisualStyleBackColor = true;
            btnUpdateRequestedService.Click += btnUpdateRequestedService_Click;
            // 
            // lblAddedServices
            // 
            lblAddedServices.AutoSize = true;
            lblAddedServices.Location = new Point(580, 19);
            lblAddedServices.Name = "lblAddedServices";
            lblAddedServices.Size = new Size(113, 15);
            lblAddedServices.TabIndex = 11;
            lblAddedServices.Text = "Servicios Agregados";
            // 
            // dgvServices
            // 
            dgvServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(482, 39);
            dgvServices.Name = "dgvServices";
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(327, 108);
            dgvServices.TabIndex = 10;
            dgvServices.CellClick += dgvServices_CellClick;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(81, 94);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(19, 97);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(43, 15);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Monto";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(81, 65);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(121, 23);
            cmbEmpleados.TabIndex = 7;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(15, 68);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(60, 15);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Empleado";
            // 
            // cmbServicios
            // 
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(81, 36);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(121, 23);
            cmbServicios.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(19, 39);
            lblService.Name = "lblService";
            lblService.Size = new Size(48, 15);
            lblService.TabIndex = 4;
            lblService.Text = "Servicio";
            // 
            // grpInfo
            // 
            grpInfo.Anchor = AnchorStyles.None;
            grpInfo.Controls.Add(cmbCliente);
            grpInfo.Controls.Add(label2);
            grpInfo.Controls.Add(cmbTipoPago);
            grpInfo.Controls.Add(label3);
            grpInfo.Location = new Point(40, 458);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(270, 100);
            grpInfo.TabIndex = 3;
            grpInfo.TabStop = false;
            grpInfo.Text = "Informacion Adicional";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(76, 60);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 11;
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
            // cmbTipoPago
            // 
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(96, 31);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(121, 23);
            cmbTipoPago.TabIndex = 9;
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
            // btnGenerateFactura
            // 
            btnGenerateFactura.Anchor = AnchorStyles.None;
            btnGenerateFactura.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateFactura.Location = new Point(360, 492);
            btnGenerateFactura.Name = "btnGenerateFactura";
            btnGenerateFactura.Size = new Size(489, 66);
            btnGenerateFactura.TabIndex = 4;
            btnGenerateFactura.Text = "Generar Factura";
            btnGenerateFactura.UseVisualStyleBackColor = true;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(885, 584);
            Controls.Add(btnGenerateFactura);
            Controls.Add(grpInfo);
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
        private ComboBox cmbCliente;
        private Label label2;
        private ComboBox cmbTipoPago;
        private Label label3;
        private Button btnGenerateFactura;
    }
}
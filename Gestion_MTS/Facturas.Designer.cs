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
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(334, 47);
            label1.Name = "label1";
            label1.Size = new Size(305, 26);
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
            grpProducts.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            grpProducts.Location = new Point(54, 131);
            grpProducts.Margin = new Padding(3, 4, 3, 4);
            grpProducts.Name = "grpProducts";
            grpProducts.Padding = new Padding(3, 4, 3, 4);
            grpProducts.Size = new Size(931, 193);
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
            btnDeleteRequestedProduct.Location = new Point(317, 111);
            btnDeleteRequestedProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteRequestedProduct.Name = "btnDeleteRequestedProduct";
            btnDeleteRequestedProduct.Size = new Size(156, 31);
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
            btnUpdateRequestedProduct.Location = new Point(317, 51);
            btnUpdateRequestedProduct.Margin = new Padding(3, 4, 3, 4);
            btnUpdateRequestedProduct.Name = "btnUpdateRequestedProduct";
            btnUpdateRequestedProduct.Size = new Size(156, 31);
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
            btnAddProduct.Location = new Point(17, 155);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(156, 31);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Agregar Producto";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblAddedProducts
            // 
            lblAddedProducts.AutoSize = true;
            lblAddedProducts.Location = new Point(654, 25);
            lblAddedProducts.Name = "lblAddedProducts";
            lblAddedProducts.Size = new Size(138, 17);
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
            dgvProducts.Location = new Point(544, 52);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(381, 133);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(93, 107);
            txtProductQuantity.Margin = new Padding(3, 4, 3, 4);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(114, 25);
            txtProductQuantity.TabIndex = 3;
            txtProductQuantity.KeyPress += txtProductQuantity_KeyPress;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 111);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(62, 17);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Cantidad";
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(93, 47);
            cmbProducts.Margin = new Padding(3, 4, 3, 4);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(138, 25);
            cmbProducts.TabIndex = 1;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(22, 51);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(63, 17);
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
            grpServices.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            grpServices.Location = new Point(54, 371);
            grpServices.Margin = new Padding(3, 4, 3, 4);
            grpServices.Name = "grpServices";
            grpServices.Padding = new Padding(3, 4, 3, 4);
            grpServices.Size = new Size(931, 204);
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
            btnAddService.Location = new Point(22, 165);
            btnAddService.Margin = new Padding(3, 4, 3, 4);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(156, 31);
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
            btnDeleteRequestedService.Location = new Point(317, 108);
            btnDeleteRequestedService.Margin = new Padding(3, 4, 3, 4);
            btnDeleteRequestedService.Name = "btnDeleteRequestedService";
            btnDeleteRequestedService.Size = new Size(156, 31);
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
            btnUpdateRequestedService.Location = new Point(317, 48);
            btnUpdateRequestedService.Margin = new Padding(3, 4, 3, 4);
            btnUpdateRequestedService.Name = "btnUpdateRequestedService";
            btnUpdateRequestedService.Size = new Size(156, 31);
            btnUpdateRequestedService.TabIndex = 12;
            btnUpdateRequestedService.Text = "Actualizar Pedido";
            btnUpdateRequestedService.UseVisualStyleBackColor = false;
            btnUpdateRequestedService.Click += btnUpdateRequestedService_Click;
            // 
            // lblAddedServices
            // 
            lblAddedServices.AutoSize = true;
            lblAddedServices.Location = new Point(663, 25);
            lblAddedServices.Name = "lblAddedServices";
            lblAddedServices.Size = new Size(130, 17);
            lblAddedServices.TabIndex = 11;
            lblAddedServices.Text = "Servicios Agregados";
            // 
            // dgvServices
            // 
            dgvServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = SystemColors.ButtonHighlight;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(551, 52);
            dgvServices.Margin = new Padding(3, 4, 3, 4);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(374, 144);
            dgvServices.TabIndex = 10;
            dgvServices.CellClick += dgvServices_CellClick;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(93, 125);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(114, 25);
            txtAmount.TabIndex = 9;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(22, 129);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(48, 17);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Monto";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(93, 87);
            cmbEmpleados.Margin = new Padding(3, 4, 3, 4);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(138, 25);
            cmbEmpleados.TabIndex = 7;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(17, 91);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(67, 17);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Empleado";
            // 
            // cmbServicios
            // 
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(93, 48);
            cmbServicios.Margin = new Padding(3, 4, 3, 4);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(138, 25);
            cmbServicios.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(22, 52);
            lblService.Name = "lblService";
            lblService.Size = new Size(55, 17);
            lblService.TabIndex = 4;
            lblService.Text = "Servicio";
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 763);
            Controls.Add(grpServices);
            Controls.Add(grpProducts);
            Controls.Add(label1);
            Name = "Facturas";
            Text = "Gestión Facturas";
            Load += Facturas_Load;
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
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
    }
}
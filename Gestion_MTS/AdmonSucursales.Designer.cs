namespace Gestion_MTS
{
    partial class AdmonSucursales
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
            groupBox1 = new GroupBox();
            dgvBodegas = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnDeleteBodega = new Button();
            btnUpdateBodega = new Button();
            btnAddBodega = new Button();
            cboSucursales = new ComboBox();
            txtNombreBodegas = new TextBox();
            groupBox2 = new GroupBox();
            dgvLocalBodega = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            btnDeleteLocalBod = new Button();
            btnUpdateLocalBod = new Button();
            cboBodegas = new ComboBox();
            txtDescripcionLocalBod = new TextBox();
            btnAddLocalBod = new Button();
            groupBox3 = new GroupBox();
            dgvSucursales = new DataGridView();
            btnDeleteSucursal = new Button();
            btnUpdateSucursal = new Button();
            btnAddSucursal = new Button();
            label6 = new Label();
            label5 = new Label();
            txtTelSucur = new TextBox();
            txtUbiSucur = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBodegas).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalBodega).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBodegas);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDeleteBodega);
            groupBox1.Controls.Add(btnUpdateBodega);
            groupBox1.Controls.Add(btnAddBodega);
            groupBox1.Controls.Add(cboSucursales);
            groupBox1.Controls.Add(txtNombreBodegas);
            groupBox1.Location = new Point(367, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 558);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administracion de Bodegas";
            // 
            // dgvBodegas
            // 
            dgvBodegas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBodegas.Dock = DockStyle.Bottom;
            dgvBodegas.Location = new Point(3, 367);
            dgvBodegas.Name = "dgvBodegas";
            dgvBodegas.RowHeadersWidth = 51;
            dgvBodegas.Size = new Size(377, 188);
            dgvBodegas.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 86);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre Bodega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 86);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Sucursal";
            // 
            // btnDeleteBodega
            // 
            btnDeleteBodega.Location = new Point(269, 250);
            btnDeleteBodega.Name = "btnDeleteBodega";
            btnDeleteBodega.Size = new Size(94, 29);
            btnDeleteBodega.TabIndex = 4;
            btnDeleteBodega.Text = "Borrar";
            btnDeleteBodega.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBodega
            // 
            btnUpdateBodega.Location = new Point(149, 250);
            btnUpdateBodega.Name = "btnUpdateBodega";
            btnUpdateBodega.Size = new Size(94, 29);
            btnUpdateBodega.TabIndex = 3;
            btnUpdateBodega.Text = "Actualizar";
            btnUpdateBodega.UseVisualStyleBackColor = true;
            // 
            // btnAddBodega
            // 
            btnAddBodega.Location = new Point(21, 250);
            btnAddBodega.Name = "btnAddBodega";
            btnAddBodega.Size = new Size(94, 29);
            btnAddBodega.TabIndex = 2;
            btnAddBodega.Text = "Agregar";
            btnAddBodega.UseVisualStyleBackColor = true;
            btnAddBodega.Click += btnAddBodega_Click;
            // 
            // cboSucursales
            // 
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(7, 141);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(151, 28);
            cboSucursales.TabIndex = 1;
            // 
            // txtNombreBodegas
            // 
            txtNombreBodegas.Location = new Point(177, 141);
            txtNombreBodegas.Name = "txtNombreBodegas";
            txtNombreBodegas.Size = new Size(200, 27);
            txtNombreBodegas.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLocalBodega);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnDeleteLocalBod);
            groupBox2.Controls.Add(btnUpdateLocalBod);
            groupBox2.Controls.Add(cboBodegas);
            groupBox2.Controls.Add(txtDescripcionLocalBod);
            groupBox2.Controls.Add(btnAddLocalBod);
            groupBox2.Location = new Point(756, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 558);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Localizaciones en Bodega";
            // 
            // dgvLocalBodega
            // 
            dgvLocalBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalBodega.Dock = DockStyle.Bottom;
            dgvLocalBodega.Location = new Point(3, 367);
            dgvLocalBodega.Name = "dgvLocalBodega";
            dgvLocalBodega.RowHeadersWidth = 51;
            dgvLocalBodega.Size = new Size(372, 188);
            dgvLocalBodega.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 73);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 75);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "Bodega";
            // 
            // btnDeleteLocalBod
            // 
            btnDeleteLocalBod.Location = new Point(264, 250);
            btnDeleteLocalBod.Name = "btnDeleteLocalBod";
            btnDeleteLocalBod.Size = new Size(94, 29);
            btnDeleteLocalBod.TabIndex = 4;
            btnDeleteLocalBod.Text = "Borrar";
            btnDeleteLocalBod.UseVisualStyleBackColor = true;
            // 
            // btnUpdateLocalBod
            // 
            btnUpdateLocalBod.Location = new Point(136, 250);
            btnUpdateLocalBod.Name = "btnUpdateLocalBod";
            btnUpdateLocalBod.Size = new Size(94, 29);
            btnUpdateLocalBod.TabIndex = 3;
            btnUpdateLocalBod.Text = "Actualizar";
            btnUpdateLocalBod.UseVisualStyleBackColor = true;
            // 
            // cboBodegas
            // 
            cboBodegas.FormattingEnabled = true;
            cboBodegas.Location = new Point(8, 131);
            cboBodegas.Name = "cboBodegas";
            cboBodegas.Size = new Size(151, 28);
            cboBodegas.TabIndex = 2;
            // 
            // txtDescripcionLocalBod
            // 
            txtDescripcionLocalBod.Location = new Point(176, 130);
            txtDescripcionLocalBod.Name = "txtDescripcionLocalBod";
            txtDescripcionLocalBod.Size = new Size(170, 27);
            txtDescripcionLocalBod.TabIndex = 1;
            // 
            // btnAddLocalBod
            // 
            btnAddLocalBod.Location = new Point(11, 250);
            btnAddLocalBod.Name = "btnAddLocalBod";
            btnAddLocalBod.Size = new Size(94, 29);
            btnAddLocalBod.TabIndex = 0;
            btnAddLocalBod.Text = "Agregar";
            btnAddLocalBod.UseVisualStyleBackColor = true;
            btnAddLocalBod.Click += btnAddLocalBod_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSucursales);
            groupBox3.Controls.Add(btnDeleteSucursal);
            groupBox3.Controls.Add(btnUpdateSucursal);
            groupBox3.Controls.Add(btnAddSucursal);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtTelSucur);
            groupBox3.Controls.Add(txtUbiSucur);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(349, 558);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sucursales";
            // 
            // dgvSucursales
            // 
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Dock = DockStyle.Bottom;
            dgvSucursales.Location = new Point(3, 367);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersWidth = 51;
            dgvSucursales.Size = new Size(343, 188);
            dgvSucursales.TabIndex = 7;
            // 
            // btnDeleteSucursal
            // 
            btnDeleteSucursal.Location = new Point(238, 250);
            btnDeleteSucursal.Name = "btnDeleteSucursal";
            btnDeleteSucursal.Size = new Size(94, 29);
            btnDeleteSucursal.TabIndex = 6;
            btnDeleteSucursal.Text = "Borrar";
            btnDeleteSucursal.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSucursal
            // 
            btnUpdateSucursal.Location = new Point(119, 250);
            btnUpdateSucursal.Name = "btnUpdateSucursal";
            btnUpdateSucursal.Size = new Size(94, 29);
            btnUpdateSucursal.TabIndex = 5;
            btnUpdateSucursal.Text = "Actualizar";
            btnUpdateSucursal.UseVisualStyleBackColor = true;
            // 
            // btnAddSucursal
            // 
            btnAddSucursal.Location = new Point(6, 250);
            btnAddSucursal.Name = "btnAddSucursal";
            btnAddSucursal.Size = new Size(94, 29);
            btnAddSucursal.TabIndex = 4;
            btnAddSucursal.Text = "Agregar";
            btnAddSucursal.UseVisualStyleBackColor = true;
            btnAddSucursal.Click += btnAddSucursal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 96);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 3;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 107);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 2;
            label5.Text = "Ubicación";
            // 
            // txtTelSucur
            // 
            txtTelSucur.Location = new Point(179, 141);
            txtTelSucur.Name = "txtTelSucur";
            txtTelSucur.Size = new Size(125, 27);
            txtTelSucur.TabIndex = 1;
            // 
            // txtUbiSucur
            // 
            txtUbiSucur.Location = new Point(9, 142);
            txtUbiSucur.Name = "txtUbiSucur";
            txtUbiSucur.Size = new Size(125, 27);
            txtUbiSucur.TabIndex = 0;
            // 
            // AdmonSucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 642);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdmonSucursales";
            Text = "AdmonSucursales";
            Load += AdmonSucursales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBodegas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalBodega).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdateBodega;
        private Button btnAddBodega;
        private ComboBox cboSucursales;
        private TextBox txtNombreBodegas;
        private GroupBox groupBox2;
        private ComboBox cboBodegas;
        private TextBox txtDescripcionLocalBod;
        private Button btnAddLocalBod;
        private Button btnDeleteBodega;
        private Button btnDeleteLocalBod;
        private Button btnUpdateLocalBod;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private DataGridView dgvBodegas;
        private DataGridView dgvLocalBodega;
        private DataGridView dgvSucursales;
        private Button btnDeleteSucursal;
        private Button btnUpdateSucursal;
        private Button btnAddSucursal;
        private Label label6;
        private Label label5;
        private TextBox txtTelSucur;
        private TextBox txtUbiSucur;
    }
}
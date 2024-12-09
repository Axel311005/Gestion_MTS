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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBodegas).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalBodega).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
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
            groupBox1.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            groupBox1.Location = new Point(9, 22);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1120, 563);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvBodegas
            // 
            dgvBodegas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBodegas.BackgroundColor = SystemColors.ControlLightLight;
            dgvBodegas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBodegas.Dock = DockStyle.Bottom;
            dgvBodegas.Location = new Point(3, 371);
            dgvBodegas.Margin = new Padding(3, 4, 3, 4);
            dgvBodegas.Name = "dgvBodegas";
            dgvBodegas.RowHeadersWidth = 51;
            dgvBodegas.Size = new Size(1114, 188);
            dgvBodegas.TabIndex = 7;
            dgvBodegas.CellClick += dgvBodegas_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(564, 82);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 6;
            label2.Text = "Nombre Bodega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 82);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 5;
            label1.Text = "Sucursal";
            // 
            // btnDeleteBodega
            // 
            btnDeleteBodega.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteBodega.FlatStyle = FlatStyle.Flat;
            btnDeleteBodega.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnDeleteBodega.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteBodega.Location = new Point(626, 245);
            btnDeleteBodega.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBodega.Name = "btnDeleteBodega";
            btnDeleteBodega.Size = new Size(94, 29);
            btnDeleteBodega.TabIndex = 4;
            btnDeleteBodega.Text = "Borrar";
            btnDeleteBodega.UseVisualStyleBackColor = false;
            btnDeleteBodega.Click += btnDeleteBodega_Click_1;
            // 
            // btnUpdateBodega
            // 
            btnUpdateBodega.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateBodega.FlatStyle = FlatStyle.Flat;
            btnUpdateBodega.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnUpdateBodega.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateBodega.Location = new Point(472, 245);
            btnUpdateBodega.Margin = new Padding(3, 4, 3, 4);
            btnUpdateBodega.Name = "btnUpdateBodega";
            btnUpdateBodega.Size = new Size(94, 29);
            btnUpdateBodega.TabIndex = 3;
            btnUpdateBodega.Text = "Actualizar";
            btnUpdateBodega.UseVisualStyleBackColor = false;
            btnUpdateBodega.Click += btnUpdateBodega_Click;
            // 
            // btnAddBodega
            // 
            btnAddBodega.BackColor = Color.FromArgb(255, 128, 0);
            btnAddBodega.FlatStyle = FlatStyle.Flat;
            btnAddBodega.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnAddBodega.ForeColor = SystemColors.ButtonHighlight;
            btnAddBodega.Location = new Point(320, 245);
            btnAddBodega.Margin = new Padding(3, 4, 3, 4);
            btnAddBodega.Name = "btnAddBodega";
            btnAddBodega.Size = new Size(94, 29);
            btnAddBodega.TabIndex = 2;
            btnAddBodega.Text = "Agregar";
            btnAddBodega.UseVisualStyleBackColor = false;
            btnAddBodega.Click += btnAddBodega_Click;
            // 
            // cboSucursales
            // 
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(320, 137);
            cboSucursales.Margin = new Padding(3, 4, 3, 4);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(151, 25);
            cboSucursales.TabIndex = 1;
            // 
            // txtNombreBodegas
            // 
            txtNombreBodegas.Location = new Point(519, 137);
            txtNombreBodegas.Margin = new Padding(3, 4, 3, 4);
            txtNombreBodegas.Name = "txtNombreBodegas";
            txtNombreBodegas.Size = new Size(201, 25);
            txtNombreBodegas.TabIndex = 0;
            txtNombreBodegas.KeyPress += txtNombreBodegas_KeyPress;
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
            groupBox2.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            groupBox2.Location = new Point(0, 7);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1141, 595);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgvLocalBodega
            // 
            dgvLocalBodega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocalBodega.BackgroundColor = SystemColors.ButtonHighlight;
            dgvLocalBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalBodega.Dock = DockStyle.Bottom;
            dgvLocalBodega.Location = new Point(3, 403);
            dgvLocalBodega.Margin = new Padding(3, 4, 3, 4);
            dgvLocalBodega.Name = "dgvLocalBodega";
            dgvLocalBodega.RowHeadersWidth = 51;
            dgvLocalBodega.Size = new Size(1135, 188);
            dgvLocalBodega.TabIndex = 7;
            dgvLocalBodega.CellClick += dgvLocalBodega_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(646, 111);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 111);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 5;
            label3.Text = "Bodega";
            // 
            // btnDeleteLocalBod
            // 
            btnDeleteLocalBod.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteLocalBod.FlatStyle = FlatStyle.Flat;
            btnDeleteLocalBod.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnDeleteLocalBod.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteLocalBod.Location = new Point(676, 285);
            btnDeleteLocalBod.Margin = new Padding(3, 4, 3, 4);
            btnDeleteLocalBod.Name = "btnDeleteLocalBod";
            btnDeleteLocalBod.Size = new Size(94, 29);
            btnDeleteLocalBod.TabIndex = 4;
            btnDeleteLocalBod.Text = "Borrar";
            btnDeleteLocalBod.UseVisualStyleBackColor = false;
            btnDeleteLocalBod.Click += btnDeleteLocalBod_Click;
            // 
            // btnUpdateLocalBod
            // 
            btnUpdateLocalBod.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateLocalBod.FlatStyle = FlatStyle.Flat;
            btnUpdateLocalBod.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnUpdateLocalBod.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateLocalBod.Location = new Point(511, 285);
            btnUpdateLocalBod.Margin = new Padding(3, 4, 3, 4);
            btnUpdateLocalBod.Name = "btnUpdateLocalBod";
            btnUpdateLocalBod.Size = new Size(94, 29);
            btnUpdateLocalBod.TabIndex = 3;
            btnUpdateLocalBod.Text = "Actualizar";
            btnUpdateLocalBod.UseVisualStyleBackColor = false;
            btnUpdateLocalBod.Click += btnUpdateLocalBod_Click;
            // 
            // cboBodegas
            // 
            cboBodegas.FormattingEnabled = true;
            cboBodegas.Location = new Point(352, 165);
            cboBodegas.Margin = new Padding(3, 4, 3, 4);
            cboBodegas.Name = "cboBodegas";
            cboBodegas.Size = new Size(151, 25);
            cboBodegas.TabIndex = 2;
            // 
            // txtDescripcionLocalBod
            // 
            txtDescripcionLocalBod.Location = new Point(600, 165);
            txtDescripcionLocalBod.Margin = new Padding(3, 4, 3, 4);
            txtDescripcionLocalBod.Name = "txtDescripcionLocalBod";
            txtDescripcionLocalBod.Size = new Size(170, 25);
            txtDescripcionLocalBod.TabIndex = 1;
            txtDescripcionLocalBod.KeyPress += txtDescripcionLocalBod_KeyPress;
            // 
            // btnAddLocalBod
            // 
            btnAddLocalBod.BackColor = Color.FromArgb(255, 128, 0);
            btnAddLocalBod.FlatStyle = FlatStyle.Flat;
            btnAddLocalBod.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnAddLocalBod.ForeColor = SystemColors.ButtonHighlight;
            btnAddLocalBod.Location = new Point(352, 285);
            btnAddLocalBod.Margin = new Padding(3, 4, 3, 4);
            btnAddLocalBod.Name = "btnAddLocalBod";
            btnAddLocalBod.Size = new Size(94, 29);
            btnAddLocalBod.TabIndex = 0;
            btnAddLocalBod.Text = "Agregar";
            btnAddLocalBod.UseVisualStyleBackColor = false;
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
            groupBox3.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            groupBox3.Location = new Point(6, 18);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1079, 542);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dgvSucursales
            // 
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Dock = DockStyle.Bottom;
            dgvSucursales.Location = new Point(3, 350);
            dgvSucursales.Margin = new Padding(3, 4, 3, 4);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersWidth = 51;
            dgvSucursales.Size = new Size(1073, 188);
            dgvSucursales.TabIndex = 7;
            dgvSucursales.CellClick += dgvSucursales_CellClick;
            // 
            // btnDeleteSucursal
            // 
            btnDeleteSucursal.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteSucursal.FlatStyle = FlatStyle.Flat;
            btnDeleteSucursal.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnDeleteSucursal.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteSucursal.Location = new Point(613, 273);
            btnDeleteSucursal.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSucursal.Name = "btnDeleteSucursal";
            btnDeleteSucursal.Size = new Size(94, 29);
            btnDeleteSucursal.TabIndex = 6;
            btnDeleteSucursal.Text = "Borrar";
            btnDeleteSucursal.UseVisualStyleBackColor = false;
            btnDeleteSucursal.Click += btnDeleteSucursal_Click;
            // 
            // btnUpdateSucursal
            // 
            btnUpdateSucursal.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateSucursal.FlatStyle = FlatStyle.Flat;
            btnUpdateSucursal.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnUpdateSucursal.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateSucursal.Location = new Point(495, 273);
            btnUpdateSucursal.Margin = new Padding(3, 4, 3, 4);
            btnUpdateSucursal.Name = "btnUpdateSucursal";
            btnUpdateSucursal.Size = new Size(94, 29);
            btnUpdateSucursal.TabIndex = 5;
            btnUpdateSucursal.Text = "Actualizar";
            btnUpdateSucursal.UseVisualStyleBackColor = false;
            btnUpdateSucursal.Click += btnUpdateSucursal_Click;
            // 
            // btnAddSucursal
            // 
            btnAddSucursal.BackColor = Color.FromArgb(255, 128, 0);
            btnAddSucursal.FlatStyle = FlatStyle.Flat;
            btnAddSucursal.Font = new Font("Segoe UI Variable Display", 7.8F, FontStyle.Bold);
            btnAddSucursal.ForeColor = SystemColors.ButtonHighlight;
            btnAddSucursal.Location = new Point(382, 273);
            btnAddSucursal.Margin = new Padding(3, 4, 3, 4);
            btnAddSucursal.Name = "btnAddSucursal";
            btnAddSucursal.Size = new Size(94, 29);
            btnAddSucursal.TabIndex = 4;
            btnAddSucursal.Text = "Agregar";
            btnAddSucursal.UseVisualStyleBackColor = false;
            btnAddSucursal.Click += btnAddSucursal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(590, 131);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 3;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 131);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 2;
            label5.Text = "Ubicación";
            // 
            // txtTelSucur
            // 
            txtTelSucur.Location = new Point(556, 166);
            txtTelSucur.Margin = new Padding(3, 4, 3, 4);
            txtTelSucur.Name = "txtTelSucur";
            txtTelSucur.Size = new Size(125, 25);
            txtTelSucur.TabIndex = 1;
            txtTelSucur.KeyPress += txtTelSucur_KeyPress;
            // 
            // txtUbiSucur
            // 
            txtUbiSucur.Location = new Point(408, 166);
            txtUbiSucur.Margin = new Padding(3, 4, 3, 4);
            txtUbiSucur.Name = "txtUbiSucur";
            txtUbiSucur.Size = new Size(125, 25);
            txtUbiSucur.TabIndex = 0;
            txtUbiSucur.KeyPress += txtUbiSucur_KeyPress;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1155, 642);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1147, 609);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sucursales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1147, 609);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Administración de Bodegas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1147, 609);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Localización en Bodega";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // AdmonSucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 642);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdmonSucursales";
            Text = "Gestión de Sucursales";
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
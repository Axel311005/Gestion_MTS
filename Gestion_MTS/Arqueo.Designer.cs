namespace Gestion_MTS
{
    partial class Arqueo
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnUpdateGasto = new Button();
            btnDeleteGasto = new Button();
            dgvGastos = new DataGridView();
            groupBox1 = new GroupBox();
            cboSucursal = new ComboBox();
            txtMontogasto = new TextBox();
            txtdescripgastos = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnAddGasto = new Button();
            tabPage2 = new TabPage();
            label1 = new Label();
            txtTotal = new TextBox();
            cboSucursales = new ComboBox();
            label3 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label2 = new Label();
            ObtenerGastos = new Button();
            dtpFechaFinal = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1057, 626);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnUpdateGasto);
            tabPage1.Controls.Add(btnDeleteGasto);
            tabPage1.Controls.Add(dgvGastos);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnAddGasto);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1049, 597);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gasto";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnUpdateGasto
            // 
            btnUpdateGasto.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateGasto.FlatStyle = FlatStyle.Flat;
            btnUpdateGasto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateGasto.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateGasto.Location = new Point(615, 139);
            btnUpdateGasto.Name = "btnUpdateGasto";
            btnUpdateGasto.Size = new Size(116, 36);
            btnUpdateGasto.TabIndex = 17;
            btnUpdateGasto.Text = "Editar";
            btnUpdateGasto.UseVisualStyleBackColor = false;
            btnUpdateGasto.Click += btnUpdateGasto_Click_1;
            // 
            // btnDeleteGasto
            // 
            btnDeleteGasto.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteGasto.FlatStyle = FlatStyle.Flat;
            btnDeleteGasto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteGasto.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteGasto.Location = new Point(615, 214);
            btnDeleteGasto.Name = "btnDeleteGasto";
            btnDeleteGasto.Size = new Size(116, 36);
            btnDeleteGasto.TabIndex = 16;
            btnDeleteGasto.Text = "Borrar";
            btnDeleteGasto.UseVisualStyleBackColor = false;
            btnDeleteGasto.Click += btnDeleteGasto_Click_1;
            // 
            // dgvGastos
            // 
            dgvGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Dock = DockStyle.Bottom;
            dgvGastos.GridColor = SystemColors.MenuHighlight;
            dgvGastos.Location = new Point(3, 407);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.Size = new Size(1043, 187);
            dgvGastos.TabIndex = 15;
            dgvGastos.CellClick += dgvGastos_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSucursal);
            groupBox1.Controls.Add(txtMontogasto);
            groupBox1.Controls.Add(txtdescripgastos);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            groupBox1.Location = new Point(19, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 285);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de Gastos";
            // 
            // cboSucursal
            // 
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(194, 168);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(233, 25);
            cboSucursal.TabIndex = 16;
            // 
            // txtMontogasto
            // 
            txtMontogasto.Location = new Point(194, 112);
            txtMontogasto.Name = "txtMontogasto";
            txtMontogasto.Size = new Size(233, 25);
            txtMontogasto.TabIndex = 15;
            txtMontogasto.KeyPress += txtMontogasto_KeyPress;
            // 
            // txtdescripgastos
            // 
            txtdescripgastos.Location = new Point(194, 64);
            txtdescripgastos.Name = "txtdescripgastos";
            txtdescripgastos.Size = new Size(233, 25);
            txtdescripgastos.TabIndex = 14;
            txtdescripgastos.KeyPress += txtdescripgastos_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 119);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 13;
            label7.Text = "Monto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 175);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 12;
            label6.Text = "Sucursal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            label4.Location = new Point(26, 64);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 10;
            label4.Text = "Descripción";
            // 
            // btnAddGasto
            // 
            btnAddGasto.BackColor = Color.FromArgb(255, 128, 0);
            btnAddGasto.FlatStyle = FlatStyle.Flat;
            btnAddGasto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGasto.ForeColor = SystemColors.ButtonHighlight;
            btnAddGasto.Location = new Point(615, 68);
            btnAddGasto.Name = "btnAddGasto";
            btnAddGasto.Size = new Size(116, 36);
            btnAddGasto.TabIndex = 11;
            btnAddGasto.Text = "Agregar";
            btnAddGasto.UseVisualStyleBackColor = false;
            btnAddGasto.Click += btnAddGasto_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtTotal);
            tabPage2.Controls.Add(cboSucursales);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dtpFechaInicio);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(ObtenerGastos);
            tabPage2.Controls.Add(dtpFechaFinal);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1025, 559);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Arqueo de Caja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(190, 88);
            label1.Name = "label1";
            label1.Size = new Size(142, 26);
            label1.TabIndex = 13;
            label1.Text = "Sucursales";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(403, 277);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(194, 22);
            txtTotal.TabIndex = 16;
            // 
            // cboSucursales
            // 
            cboSucursales.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(191, 136);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(151, 25);
            cboSucursales.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(682, 85);
            label3.Name = "label3";
            label3.Size = new Size(150, 26);
            label3.TabIndex = 15;
            label3.Text = "Fecha Final";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            dtpFechaInicio.Location = new Point(377, 137);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 25);
            dtpFechaInicio.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(438, 88);
            label2.Name = "label2";
            label2.Size = new Size(159, 26);
            label2.TabIndex = 14;
            label2.Text = "Fecha Inicio";
            // 
            // ObtenerGastos
            // 
            ObtenerGastos.BackColor = Color.FromArgb(255, 128, 0);
            ObtenerGastos.FlatStyle = FlatStyle.Flat;
            ObtenerGastos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ObtenerGastos.ForeColor = SystemColors.ButtonHighlight;
            ObtenerGastos.Location = new Point(381, 207);
            ObtenerGastos.Name = "ObtenerGastos";
            ObtenerGastos.Size = new Size(246, 35);
            ObtenerGastos.TabIndex = 11;
            ObtenerGastos.Text = "Obtener";
            ObtenerGastos.UseVisualStyleBackColor = false;
            ObtenerGastos.Click += ObtenerGastos_Click_1;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            dtpFechaFinal.Location = new Point(642, 134);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(250, 25);
            dtpFechaFinal.TabIndex = 12;
            // 
            // Arqueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 626);
            Controls.Add(tabControl1);
            Name = "Arqueo";
            Text = "Arqueo";
            Load += Arqueo_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtTotal;
        private ComboBox cboSucursales;
        private Label label3;
        private DateTimePicker dtpFechaInicio;
        private Label label2;
        private Button ObtenerGastos;
        private DateTimePicker dtpFechaFinal;
        private Label label4;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnDeleteProd;
        private Button btnUpdateProd;
        private Button btnAddGasto;
        private DataGridView dgvGastos;
        private ComboBox cboSucursal;
        private TextBox txtMontogasto;
        private TextBox txtdescripgastos;
        private Button btnUpdateGasto;
        private Button btnDeleteGasto;
    }
}
namespace Gestion_MTS
{
    partial class Informacion_Adicional
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
            dgvClientes = new DataGridView();
            btnDeleteCliente = new Button();
            btnUpdateCliente = new Button();
            btnAddCliente = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDireccion = new TextBox();
            txtApellidoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTipoDePago = new TextBox();
            btnDeleteTipo = new Button();
            btnUpdateTipo = new Button();
            btnAddTipo = new Button();
            dgvTipoPago = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoPago).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            tabControl1.Location = new Point(12, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1101, 552);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Controls.Add(btnDeleteCliente);
            tabPage1.Controls.Add(btnUpdateCliente);
            tabPage1.Controls.Add(btnAddCliente);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1093, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Dock = DockStyle.Bottom;
            dgvClientes.Location = new Point(3, 345);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(1087, 175);
            dgvClientes.TabIndex = 13;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnDeleteCliente
            // 
            btnDeleteCliente.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteCliente.FlatStyle = FlatStyle.Flat;
            btnDeleteCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCliente.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteCliente.Location = new Point(780, 208);
            btnDeleteCliente.Name = "btnDeleteCliente";
            btnDeleteCliente.Size = new Size(116, 36);
            btnDeleteCliente.TabIndex = 12;
            btnDeleteCliente.Text = "Borrar";
            btnDeleteCliente.UseVisualStyleBackColor = false;
            btnDeleteCliente.Click += btnDeleteCliente_Click;
            // 
            // btnUpdateCliente
            // 
            btnUpdateCliente.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateCliente.FlatStyle = FlatStyle.Flat;
            btnUpdateCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCliente.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateCliente.Location = new Point(780, 147);
            btnUpdateCliente.Name = "btnUpdateCliente";
            btnUpdateCliente.Size = new Size(116, 36);
            btnUpdateCliente.TabIndex = 11;
            btnUpdateCliente.Text = "Actualizar";
            btnUpdateCliente.UseVisualStyleBackColor = false;
            btnUpdateCliente.Click += btnUpdateCliente_Click;
            // 
            // btnAddCliente
            // 
            btnAddCliente.BackColor = Color.FromArgb(255, 128, 0);
            btnAddCliente.FlatStyle = FlatStyle.Flat;
            btnAddCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCliente.ForeColor = SystemColors.ButtonHighlight;
            btnAddCliente.Location = new Point(780, 92);
            btnAddCliente.Name = "btnAddCliente";
            btnAddCliente.Size = new Size(116, 36);
            btnAddCliente.TabIndex = 10;
            btnAddCliente.Text = "Agregar";
            btnAddCliente.UseVisualStyleBackColor = false;
            btnAddCliente.Click += btnAddCliente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtApellidoCliente);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 214);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 17;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 151);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 16;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 86);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 207);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(234, 25);
            txtDireccion.TabIndex = 14;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(160, 146);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(234, 25);
            txtApellidoCliente.TabIndex = 13;
            txtApellidoCliente.KeyPress += txtApellidoCliente_KeyPress;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(160, 80);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(234, 25);
            txtNombreCliente.TabIndex = 12;
            txtNombreCliente.KeyPress += txtNombreCliente_KeyPress;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(btnDeleteTipo);
            tabPage2.Controls.Add(btnUpdateTipo);
            tabPage2.Controls.Add(btnAddTipo);
            tabPage2.Controls.Add(dgvTipoPago);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1093, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tipos de pago";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTipoDePago);
            groupBox2.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 215);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestión Tipos de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 82);
            label4.Name = "label4";
            label4.Size = new Size(137, 17);
            label4.TabIndex = 17;
            label4.Text = "Nombre Tipo de Pago";
            // 
            // txtTipoDePago
            // 
            txtTipoDePago.Location = new Point(245, 83);
            txtTipoDePago.Name = "txtTipoDePago";
            txtTipoDePago.Size = new Size(234, 25);
            txtTipoDePago.TabIndex = 16;
            txtTipoDePago.KeyPress += txtTipoDePago_KeyPress;
            // 
            // btnDeleteTipo
            // 
            btnDeleteTipo.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteTipo.FlatStyle = FlatStyle.Flat;
            btnDeleteTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTipo.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteTipo.Location = new Point(765, 196);
            btnDeleteTipo.Name = "btnDeleteTipo";
            btnDeleteTipo.Size = new Size(116, 36);
            btnDeleteTipo.TabIndex = 17;
            btnDeleteTipo.Text = "Borrar";
            btnDeleteTipo.UseVisualStyleBackColor = false;
            btnDeleteTipo.Click += btnDeleteTipo_Click;
            // 
            // btnUpdateTipo
            // 
            btnUpdateTipo.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateTipo.FlatStyle = FlatStyle.Flat;
            btnUpdateTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateTipo.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateTipo.Location = new Point(765, 135);
            btnUpdateTipo.Name = "btnUpdateTipo";
            btnUpdateTipo.Size = new Size(116, 36);
            btnUpdateTipo.TabIndex = 16;
            btnUpdateTipo.Text = "Actualizar";
            btnUpdateTipo.UseVisualStyleBackColor = false;
            btnUpdateTipo.Click += btnUpdateTipo_Click;
            // 
            // btnAddTipo
            // 
            btnAddTipo.BackColor = Color.FromArgb(255, 128, 0);
            btnAddTipo.FlatStyle = FlatStyle.Flat;
            btnAddTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTipo.ForeColor = SystemColors.ButtonHighlight;
            btnAddTipo.Location = new Point(765, 80);
            btnAddTipo.Name = "btnAddTipo";
            btnAddTipo.Size = new Size(116, 36);
            btnAddTipo.TabIndex = 15;
            btnAddTipo.Text = "Agregar";
            btnAddTipo.UseVisualStyleBackColor = false;
            btnAddTipo.Click += btnAddTipo_Click;
            // 
            // dgvTipoPago
            // 
            dgvTipoPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoPago.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTipoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoPago.Dock = DockStyle.Bottom;
            dgvTipoPago.Location = new Point(3, 294);
            dgvTipoPago.Name = "dgvTipoPago";
            dgvTipoPago.RowHeadersWidth = 51;
            dgvTipoPago.Size = new Size(1087, 226);
            dgvTipoPago.TabIndex = 14;
            dgvTipoPago.CellClick += dgvTipoPago_CellClick;
            // 
            // Informacion_Adicional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 557);
            Controls.Add(tabControl1);
            Name = "Informacion_Adicional";
            Text = "Informacion_Adicional";
            Load += Informacion_Adicional_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private Button btnDeleteCliente;
        private Button btnUpdateCliente;
        private Button btnAddCliente;
        private DataGridView dgvClientes;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccion;
        private TextBox txtApellidoCliente;
        private TextBox txtNombreCliente;
        private DataGridView dgvTipoPago;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTipoDePago;
        private Button btnDeleteTipo;
        private Button btnUpdateTipo;
        private Button btnAddTipo;
    }
}
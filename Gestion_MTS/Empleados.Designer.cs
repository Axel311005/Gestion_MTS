namespace Gestion_MTS
{
    partial class Empleados
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
            btnDeleteEmpleado = new Button();
            btnUpdateEmpleado = new Button();
            btnAddEmpleado = new Button();
            dgvEmpleados = new DataGridView();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Nombre = new Label();
            cboSucursal = new ComboBox();
            cboRoles = new ComboBox();
            txtSalario = new TextBox();
            txtCelular = new TextBox();
            chbEstado = new CheckBox();
            dtpNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            txtCedula = new TextBox();
            txtApellidoEmpleado = new TextBox();
            txtNombreEmpleado = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            tabControl1.Location = new Point(0, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1045, 615);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(btnDeleteEmpleado);
            tabPage1.Controls.Add(btnUpdateEmpleado);
            tabPage1.Controls.Add(btnAddEmpleado);
            tabPage1.Controls.Add(dgvEmpleados);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1037, 586);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar Empleado";
            // 
            // btnDeleteEmpleado
            // 
            btnDeleteEmpleado.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteEmpleado.FlatStyle = FlatStyle.Flat;
            btnDeleteEmpleado.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteEmpleado.Location = new Point(869, 208);
            btnDeleteEmpleado.Name = "btnDeleteEmpleado";
            btnDeleteEmpleado.Size = new Size(116, 36);
            btnDeleteEmpleado.TabIndex = 6;
            btnDeleteEmpleado.Text = "Borrar";
            btnDeleteEmpleado.UseVisualStyleBackColor = false;
            btnDeleteEmpleado.Click += btnDeleteEmpleado_Click;
            // 
            // btnUpdateEmpleado
            // 
            btnUpdateEmpleado.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateEmpleado.FlatStyle = FlatStyle.Flat;
            btnUpdateEmpleado.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateEmpleado.Location = new Point(869, 147);
            btnUpdateEmpleado.Name = "btnUpdateEmpleado";
            btnUpdateEmpleado.Size = new Size(116, 36);
            btnUpdateEmpleado.TabIndex = 5;
            btnUpdateEmpleado.Text = "Editar";
            btnUpdateEmpleado.UseVisualStyleBackColor = false;
            btnUpdateEmpleado.Click += btnUpdateEmpleado_Click;
            // 
            // btnAddEmpleado
            // 
            btnAddEmpleado.BackColor = Color.FromArgb(255, 128, 0);
            btnAddEmpleado.FlatStyle = FlatStyle.Flat;
            btnAddEmpleado.ForeColor = SystemColors.ButtonHighlight;
            btnAddEmpleado.Location = new Point(869, 92);
            btnAddEmpleado.Name = "btnAddEmpleado";
            btnAddEmpleado.Size = new Size(116, 36);
            btnAddEmpleado.TabIndex = 4;
            btnAddEmpleado.Text = "Agregar";
            btnAddEmpleado.UseVisualStyleBackColor = false;
            btnAddEmpleado.Click += btnAddEmpleado_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Dock = DockStyle.Bottom;
            dgvEmpleados.GridColor = SystemColors.MenuHighlight;
            dgvEmpleados.Location = new Point(3, 396);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1031, 187);
            dgvEmpleados.TabIndex = 3;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Nombre);
            groupBox1.Controls.Add(cboSucursal);
            groupBox1.Controls.Add(cboRoles);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(chbEstado);
            groupBox1.Controls.Add(dtpNacimiento);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(txtApellidoEmpleado);
            groupBox1.Controls.Add(txtNombreEmpleado);
            groupBox1.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            groupBox1.Location = new Point(17, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 336);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Empleado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(372, 142);
            label10.Name = "label10";
            label10.Size = new Size(57, 17);
            label10.TabIndex = 21;
            label10.Text = "Sucursal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 94);
            label9.Name = "label9";
            label9.Size = new Size(27, 17);
            label9.TabIndex = 20;
            label9.Text = "Rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 60);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 17;
            label6.Text = "Fecha  Nacimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 279);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 16;
            label1.Text = "Salario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 229);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 15;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 180);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 14;
            label4.Text = "Celular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 134);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 13;
            label3.Text = "Cedula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 92);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 12;
            label2.Text = "Apellido";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(22, 54);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(57, 17);
            Nombre.TabIndex = 11;
            Nombre.Text = "Nombre";
            // 
            // cboSucursal
            // 
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(510, 134);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(250, 25);
            cboSucursal.TabIndex = 10;
            // 
            // cboRoles
            // 
            cboRoles.FormattingEnabled = true;
            cboRoles.Location = new Point(510, 91);
            cboRoles.Name = "cboRoles";
            cboRoles.Size = new Size(250, 25);
            cboRoles.TabIndex = 9;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(100, 276);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(193, 25);
            txtSalario.TabIndex = 8;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(100, 180);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(193, 25);
            txtCelular.TabIndex = 7;
            // 
            // chbEstado
            // 
            chbEstado.AutoSize = true;
            chbEstado.Location = new Point(510, 182);
            chbEstado.Name = "chbEstado";
            chbEstado.Size = new Size(71, 21);
            chbEstado.TabIndex = 6;
            chbEstado.Text = "Estado";
            chbEstado.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(510, 55);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(250, 25);
            dtpNacimiento.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(100, 226);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(193, 25);
            txtDireccion.TabIndex = 4;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(100, 134);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(193, 25);
            txtCedula.TabIndex = 2;
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Location = new Point(100, 92);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(193, 25);
            txtApellidoEmpleado.TabIndex = 1;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(100, 54);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(193, 25);
            txtNombreEmpleado.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1037, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 626);
            Controls.Add(tabControl1);
            Name = "Empleados";
            Text = "Gestión Empleados";
            Load += Empleados_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvEmpleados;
        private GroupBox groupBox1;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Nombre;
        private ComboBox cboSucursal;
        private ComboBox cboRoles;
        private TextBox txtSalario;
        private TextBox txtCelular;
        private CheckBox chbEstado;
        private DateTimePicker dtpNacimiento;
        private TextBox txtDireccion;
        private TextBox txtCedula;
        private TextBox txtApellidoEmpleado;
        private TextBox txtNombreEmpleado;
        private TabPage tabPage2;
        private Button btnDeleteEmpleado;
        private Button btnUpdateEmpleado;
        private Button btnAddEmpleado;
        private Label label10;
        private Label label9;
    }
}
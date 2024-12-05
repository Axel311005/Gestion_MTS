﻿namespace Gestion_MTS
{
    partial class Productos
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
            btnDeleteProd = new Button();
            btnUpdateProd = new Button();
            btnAddProd = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboLocalicacion = new ComboBox();
            cboCategoria = new ComboBox();
            chkEstado = new CheckBox();
            txtStockMin = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtDescripProd = new TextBox();
            txtNombreProd = new TextBox();
            txtCodigo = new TextBox();
            dgvProductos = new DataGridView();
            tabPage2 = new TabPage();
            dgvCategorias = new DataGridView();
            btnDeleteCateg = new Button();
            btnUpdateCateg = new Button();
            btnAddCateg = new Button();
            label10 = new Label();
            label11 = new Label();
            txtDescripcionCateg = new TextBox();
            txtNombreCategoria = new TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            txtNombreProv = new TextBox();
            txtDirecciónProv = new TextBox();
            txtTelefonoProv = new TextBox();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBox2 = new GroupBox();
            btnDeleteProv = new Button();
            btnUpdateProv = new Button();
            btnAddProv = new Button();
            dgvProveedores = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox3 = new GroupBox();
            dgvCompras = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            comboBox3 = new ComboBox();
            label19 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1105, 586);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(btnDeleteProd);
            tabPage1.Controls.Add(btnUpdateProd);
            tabPage1.Controls.Add(btnAddProd);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dgvProductos);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1097, 557);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar Productos";
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteProd.FlatStyle = FlatStyle.Flat;
            btnDeleteProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProd.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteProd.Location = new Point(874, 211);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(116, 36);
            btnDeleteProd.TabIndex = 9;
            btnDeleteProd.Text = "Borrar";
            btnDeleteProd.UseVisualStyleBackColor = false;
            btnDeleteProd.Click += btnDeleteProd_Click;
            // 
            // btnUpdateProd
            // 
            btnUpdateProd.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateProd.FlatStyle = FlatStyle.Flat;
            btnUpdateProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProd.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateProd.Location = new Point(874, 150);
            btnUpdateProd.Name = "btnUpdateProd";
            btnUpdateProd.Size = new Size(116, 36);
            btnUpdateProd.TabIndex = 8;
            btnUpdateProd.Text = "Actualizar";
            btnUpdateProd.UseVisualStyleBackColor = false;
            btnUpdateProd.Click += btnUpdateProd_Click;
            // 
            // btnAddProd
            // 
            btnAddProd.BackColor = Color.FromArgb(255, 128, 0);
            btnAddProd.FlatStyle = FlatStyle.Flat;
            btnAddProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProd.ForeColor = SystemColors.ButtonHighlight;
            btnAddProd.Location = new Point(874, 95);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(116, 36);
            btnAddProd.TabIndex = 7;
            btnAddProd.Text = "Agregar";
            btnAddProd.UseVisualStyleBackColor = false;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboLocalicacion);
            groupBox1.Controls.Add(cboCategoria);
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(txtStockMin);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtDescripProd);
            groupBox1.Controls.Add(txtNombreProd);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de Productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(380, 167);
            label8.Name = "label8";
            label8.Size = new Size(80, 17);
            label8.TabIndex = 16;
            label8.Text = "Localizacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 100);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 15;
            label7.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 297);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 14;
            label6.Text = "Stock Minimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 250);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 13;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 202);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 12;
            label4.Text = "Precio Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 152);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 11;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 105);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 55);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 9;
            label1.Text = "Codigo";
            // 
            // cboLocalicacion
            // 
            cboLocalicacion.FormattingEnabled = true;
            cboLocalicacion.Location = new Point(490, 167);
            cboLocalicacion.Name = "cboLocalicacion";
            cboLocalicacion.Size = new Size(151, 25);
            cboLocalicacion.TabIndex = 8;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(490, 97);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(151, 25);
            cboCategoria.TabIndex = 7;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(490, 250);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(71, 21);
            chkEstado.TabIndex = 6;
            chkEstado.Text = "Estado";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(154, 290);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(125, 25);
            txtStockMin.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(154, 243);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 25);
            txtStock.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(154, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 25);
            txtPrecio.TabIndex = 3;
            // 
            // txtDescripProd
            // 
            txtDescripProd.Location = new Point(154, 145);
            txtDescripProd.Name = "txtDescripProd";
            txtDescripProd.Size = new Size(125, 25);
            txtDescripProd.TabIndex = 2;
            // 
            // txtNombreProd
            // 
            txtNombreProd.Location = new Point(154, 100);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(125, 25);
            txtNombreProd.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(154, 49);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 25);
            txtCodigo.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Bottom;
            dgvProductos.Location = new Point(3, 379);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(1091, 175);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(dgvCategorias);
            tabPage2.Controls.Add(btnDeleteCateg);
            tabPage2.Controls.Add(btnUpdateCateg);
            tabPage2.Controls.Add(btnAddCateg);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtDescripcionCateg);
            tabPage2.Controls.Add(txtNombreCategoria);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1097, 557);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Categorias Productos";
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = SystemColors.Control;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Dock = DockStyle.Bottom;
            dgvCategorias.Location = new Point(3, 333);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(1091, 221);
            dgvCategorias.TabIndex = 21;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // btnDeleteCateg
            // 
            btnDeleteCateg.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteCateg.FlatStyle = FlatStyle.Flat;
            btnDeleteCateg.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteCateg.Location = new Point(623, 214);
            btnDeleteCateg.Name = "btnDeleteCateg";
            btnDeleteCateg.Size = new Size(116, 36);
            btnDeleteCateg.TabIndex = 20;
            btnDeleteCateg.Text = "Eliminar";
            btnDeleteCateg.UseVisualStyleBackColor = false;
            btnDeleteCateg.Click += btnDeleteCateg_Click;
            // 
            // btnUpdateCateg
            // 
            btnUpdateCateg.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateCateg.FlatStyle = FlatStyle.Flat;
            btnUpdateCateg.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateCateg.Location = new Point(472, 214);
            btnUpdateCateg.Name = "btnUpdateCateg";
            btnUpdateCateg.Size = new Size(116, 36);
            btnUpdateCateg.TabIndex = 19;
            btnUpdateCateg.Text = "Actualizar";
            btnUpdateCateg.UseVisualStyleBackColor = false;
            btnUpdateCateg.Click += btnUpdateCateg_Click;
            // 
            // btnAddCateg
            // 
            btnAddCateg.BackColor = Color.FromArgb(255, 128, 0);
            btnAddCateg.FlatStyle = FlatStyle.Flat;
            btnAddCateg.ForeColor = SystemColors.ButtonHighlight;
            btnAddCateg.Location = new Point(306, 214);
            btnAddCateg.Name = "btnAddCateg";
            btnAddCateg.Size = new Size(116, 36);
            btnAddCateg.TabIndex = 18;
            btnAddCateg.Text = "Agregar";
            btnAddCateg.UseVisualStyleBackColor = false;
            btnAddCateg.Click += btnAddCateg_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            label10.Location = new Point(558, 85);
            label10.Name = "label10";
            label10.Size = new Size(78, 17);
            label10.TabIndex = 17;
            label10.Text = "Descripción";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display Semib", 7.8F, FontStyle.Bold);
            label11.Location = new Point(400, 85);
            label11.Name = "label11";
            label11.Size = new Size(57, 17);
            label11.TabIndex = 16;
            label11.Text = "Nombre";
            // 
            // txtDescripcionCateg
            // 
            txtDescripcionCateg.Location = new Point(543, 142);
            txtDescripcionCateg.Name = "txtDescripcionCateg";
            txtDescripcionCateg.Size = new Size(125, 22);
            txtDescripcionCateg.TabIndex = 15;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(367, 142);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(125, 22);
            txtNombreCategoria.TabIndex = 14;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(dgvCompras);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 25);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1097, 557);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Compra de Inventario";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvProveedores);
            tabPage4.Controls.Add(btnDeleteProv);
            tabPage4.Controls.Add(btnUpdateProv);
            tabPage4.Controls.Add(btnAddProv);
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Location = new Point(4, 25);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1097, 557);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Proveedores";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtNombreProv
            // 
            txtNombreProv.Location = new Point(127, 54);
            txtNombreProv.Name = "txtNombreProv";
            txtNombreProv.Size = new Size(194, 22);
            txtNombreProv.TabIndex = 0;
            // 
            // txtDirecciónProv
            // 
            txtDirecciónProv.Location = new Point(136, 190);
            txtDirecciónProv.Name = "txtDirecciónProv";
            txtDirecciónProv.Size = new Size(194, 22);
            txtDirecciónProv.TabIndex = 1;
            // 
            // txtTelefonoProv
            // 
            txtTelefonoProv.Location = new Point(127, 129);
            txtTelefonoProv.Name = "txtTelefonoProv";
            txtTelefonoProv.Size = new Size(194, 22);
            txtTelefonoProv.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 129);
            label9.Name = "label9";
            label9.Size = new Size(69, 16);
            label9.TabIndex = 10;
            label9.Text = "Telefono";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 193);
            label12.Name = "label12";
            label12.Size = new Size(73, 16);
            label12.TabIndex = 11;
            label12.Text = "Dirección";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 54);
            label13.Name = "label13";
            label13.Size = new Size(62, 16);
            label13.TabIndex = 12;
            label13.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNombreProv);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtDirecciónProv);
            groupBox2.Controls.Add(txtTelefonoProv);
            groupBox2.Location = new Point(6, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 291);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestión de Proveedores";
            // 
            // btnDeleteProv
            // 
            btnDeleteProv.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteProv.FlatStyle = FlatStyle.Flat;
            btnDeleteProv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProv.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteProv.Location = new Point(526, 192);
            btnDeleteProv.Name = "btnDeleteProv";
            btnDeleteProv.Size = new Size(116, 36);
            btnDeleteProv.TabIndex = 16;
            btnDeleteProv.Text = "Borrar";
            btnDeleteProv.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProv
            // 
            btnUpdateProv.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateProv.FlatStyle = FlatStyle.Flat;
            btnUpdateProv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProv.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateProv.Location = new Point(526, 131);
            btnUpdateProv.Name = "btnUpdateProv";
            btnUpdateProv.Size = new Size(116, 36);
            btnUpdateProv.TabIndex = 15;
            btnUpdateProv.Text = "Actualizar";
            btnUpdateProv.UseVisualStyleBackColor = false;
            // 
            // btnAddProv
            // 
            btnAddProv.BackColor = Color.FromArgb(255, 128, 0);
            btnAddProv.FlatStyle = FlatStyle.Flat;
            btnAddProv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProv.ForeColor = SystemColors.ButtonHighlight;
            btnAddProv.Location = new Point(526, 76);
            btnAddProv.Name = "btnAddProv";
            btnAddProv.Size = new Size(116, 36);
            btnAddProv.TabIndex = 14;
            btnAddProv.Text = "Agregar";
            btnAddProv.UseVisualStyleBackColor = false;
            // 
            // dgvProveedores
            // 
            dgvProveedores.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Dock = DockStyle.Bottom;
            dgvProveedores.Location = new Point(3, 342);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(1091, 212);
            dgvProveedores.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(621, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 24);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(611, 139);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 24);
            comboBox2.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Location = new Point(25, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(821, 327);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gestión Compra de Inventario";
            // 
            // dgvCompras
            // 
            dgvCompras.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Dock = DockStyle.Bottom;
            dgvCompras.Location = new Point(3, 379);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.Size = new Size(1091, 175);
            dgvCompras.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(897, 225);
            button1.Name = "button1";
            button1.Size = new Size(116, 36);
            button1.TabIndex = 14;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(897, 164);
            button2.Name = "button2";
            button2.Size = new Size(116, 36);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(897, 109);
            button3.Name = "button3";
            button3.Size = new Size(116, 36);
            button3.TabIndex = 12;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(477, 70);
            label14.Name = "label14";
            label14.Size = new Size(102, 16);
            label14.TabIndex = 16;
            label14.Text = "Tipo de Pago";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(31, 276);
            label15.Name = "label15";
            label15.Size = new Size(49, 16);
            label15.TabIndex = 17;
            label15.Text = "Monto";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(31, 139);
            label16.Name = "label16";
            label16.Size = new Size(69, 16);
            label16.TabIndex = 18;
            label16.Text = "Producto";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(477, 139);
            label17.Name = "label17";
            label17.Size = new Size(80, 16);
            label17.TabIndex = 19;
            label17.Text = "Proveedor";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(31, 69);
            label18.Name = "label18";
            label18.Size = new Size(139, 16);
            label18.TabIndex = 20;
            label18.Text = "Numero de Factura";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(198, 139);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(186, 24);
            comboBox3.TabIndex = 21;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(31, 211);
            label19.Name = "label19";
            label19.Size = new Size(69, 16);
            label19.TabIndex = 22;
            label19.Text = "Cantidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 22);
            textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 22);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 22);
            textBox3.TabIndex = 25;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1159, 610);
            Controls.Add(tabControl1);
            Name = "Productos";
            Text = "Gestion de Inventario";
            Load += Productos_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvProductos;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboLocalicacion;
        private ComboBox cboCategoria;
        private CheckBox chkEstado;
        private TextBox txtStockMin;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtDescripProd;
        private TextBox txtNombreProd;
        private TextBox txtCodigo;
        private Button btnDeleteProd;
        private Button btnUpdateProd;
        private Button btnAddProd;
        private DataGridView dgvCategorias;
        private Button btnDeleteCateg;
        private Button btnUpdateCateg;
        private Button btnAddCateg;
        private Label label10;
        private Label label11;
        private TextBox txtDescripcionCateg;
        private TextBox txtNombreCategoria;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox2;
        private TextBox txtNombreProv;
        private Label label12;
        private Label label13;
        private Label label9;
        private TextBox txtDirecciónProv;
        private TextBox txtTelefonoProv;
        private DataGridView dgvProveedores;
        private Button btnDeleteProv;
        private Button btnUpdateProv;
        private Button btnAddProv;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvCompras;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label19;
        private ComboBox comboBox3;
    }
}
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1105, 586);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeleteProd);
            tabPage1.Controls.Add(btnUpdateProd);
            tabPage1.Controls.Add(btnAddProd);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dgvProductos);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1097, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar Productos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.Location = new Point(874, 211);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(94, 29);
            btnDeleteProd.TabIndex = 9;
            btnDeleteProd.Text = "Borrar";
            btnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProd
            // 
            btnUpdateProd.Location = new Point(874, 150);
            btnUpdateProd.Name = "btnUpdateProd";
            btnUpdateProd.Size = new Size(94, 29);
            btnUpdateProd.TabIndex = 8;
            btnUpdateProd.Text = "Actualizar";
            btnUpdateProd.UseVisualStyleBackColor = true;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(874, 95);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(94, 29);
            btnAddProd.TabIndex = 7;
            btnAddProd.Text = "Agregar";
            btnAddProd.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(380, 167);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 16;
            label8.Text = "Localizacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 100);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 15;
            label7.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 297);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 14;
            label6.Text = "Stock Minimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 250);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 13;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 202);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 12;
            label4.Text = "Precio Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 152);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 11;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 55);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 9;
            label1.Text = "Codigo";
            // 
            // cboLocalicacion
            // 
            cboLocalicacion.FormattingEnabled = true;
            cboLocalicacion.Location = new Point(490, 167);
            cboLocalicacion.Name = "cboLocalicacion";
            cboLocalicacion.Size = new Size(151, 28);
            cboLocalicacion.TabIndex = 8;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(490, 97);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(151, 28);
            cboCategoria.TabIndex = 7;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(490, 250);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(76, 24);
            chkEstado.TabIndex = 6;
            chkEstado.Text = "Estado";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(154, 290);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(125, 27);
            txtStockMin.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(154, 243);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(154, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 3;
            // 
            // txtDescripProd
            // 
            txtDescripProd.Location = new Point(154, 145);
            txtDescripProd.Name = "txtDescripProd";
            txtDescripProd.Size = new Size(125, 27);
            txtDescripProd.TabIndex = 2;
            // 
            // txtNombreProd
            // 
            txtNombreProd.Location = new Point(154, 100);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(125, 27);
            txtNombreProd.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(154, 49);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Bottom;
            dgvProductos.Location = new Point(3, 375);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(1091, 175);
            dgvProductos.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCategorias);
            tabPage2.Controls.Add(btnDeleteCateg);
            tabPage2.Controls.Add(btnUpdateCateg);
            tabPage2.Controls.Add(btnAddCateg);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtDescripcionCateg);
            tabPage2.Controls.Add(txtNombreCategoria);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1097, 553);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Categorias Productos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Dock = DockStyle.Bottom;
            dgvCategorias.Location = new Point(3, 329);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(1091, 221);
            dgvCategorias.TabIndex = 21;
            // 
            // btnDeleteCateg
            // 
            btnDeleteCateg.Location = new Point(623, 214);
            btnDeleteCateg.Name = "btnDeleteCateg";
            btnDeleteCateg.Size = new Size(94, 29);
            btnDeleteCateg.TabIndex = 20;
            btnDeleteCateg.Text = "Eliminar";
            btnDeleteCateg.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCateg
            // 
            btnUpdateCateg.Location = new Point(472, 214);
            btnUpdateCateg.Name = "btnUpdateCateg";
            btnUpdateCateg.Size = new Size(94, 29);
            btnUpdateCateg.TabIndex = 19;
            btnUpdateCateg.Text = "Actualizar";
            btnUpdateCateg.UseVisualStyleBackColor = true;
            // 
            // btnAddCateg
            // 
            btnAddCateg.Location = new Point(306, 214);
            btnAddCateg.Name = "btnAddCateg";
            btnAddCateg.Size = new Size(94, 29);
            btnAddCateg.TabIndex = 18;
            btnAddCateg.Text = "Agregar";
            btnAddCateg.UseVisualStyleBackColor = true;
            btnAddCateg.Click += btnAddCateg_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(558, 85);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 17;
            label10.Text = "Descripción";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(400, 85);
            label11.Name = "label11";
            label11.Size = new Size(64, 20);
            label11.TabIndex = 16;
            label11.Text = "Nombre";
            // 
            // txtDescripcionCateg
            // 
            txtDescripcionCateg.Location = new Point(543, 142);
            txtDescripcionCateg.Name = "txtDescripcionCateg";
            txtDescripcionCateg.Size = new Size(125, 27);
            txtDescripcionCateg.TabIndex = 15;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(367, 142);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(125, 27);
            txtNombreCategoria.TabIndex = 14;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
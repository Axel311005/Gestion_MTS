namespace Gestion_MTS
{
    partial class Servicios
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
            label5 = new Label();
            cboCategoria = new ComboBox();
            dgvServicios = new DataGridView();
            btnDeleteServ = new Button();
            btnUpdateServ = new Button();
            btnAddServicio = new Button();
            label2 = new Label();
            label1 = new Label();
            txtDescripServ = new TextBox();
            txtNombreServ = new TextBox();
            tabPage2 = new TabPage();
            label3 = new Label();
            label4 = new Label();
            btnDeleteCat = new Button();
            btnUpdateCat = new Button();
            btnAddCateg = new Button();
            dgvCategoriaServicios = new DataGridView();
            txtDescripcionCateg = new TextBox();
            txtNombreCategoria = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriaServicios).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1186, 624);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(cboCategoria);
            tabPage1.Controls.Add(dgvServicios);
            tabPage1.Controls.Add(btnDeleteServ);
            tabPage1.Controls.Add(btnUpdateServ);
            tabPage1.Controls.Add(btnAddServicio);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtDescripServ);
            tabPage1.Controls.Add(txtNombreServ);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1178, 591);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Servicios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            label5.Location = new Point(724, 133);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(687, 190);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(151, 28);
            cboCategoria.TabIndex = 8;
            // 
            // dgvServicios
            // 
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicios.BackgroundColor = SystemColors.ButtonHighlight;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Dock = DockStyle.Bottom;
            dgvServicios.Location = new Point(3, 400);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 51;
            dgvServicios.Size = new Size(1172, 188);
            dgvServicios.TabIndex = 7;
            dgvServicios.CellClick += dgvServicios_CellClick;
            // 
            // btnDeleteServ
            // 
            btnDeleteServ.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteServ.FlatStyle = FlatStyle.Flat;
            btnDeleteServ.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteServ.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteServ.Location = new Point(733, 264);
            btnDeleteServ.Name = "btnDeleteServ";
            btnDeleteServ.Size = new Size(150, 35);
            btnDeleteServ.TabIndex = 6;
            btnDeleteServ.Text = "Eliminar";
            btnDeleteServ.UseVisualStyleBackColor = false;
            btnDeleteServ.Click += btnDeleteServ_Click;
            // 
            // btnUpdateServ
            // 
            btnUpdateServ.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateServ.FlatStyle = FlatStyle.Flat;
            btnUpdateServ.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateServ.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateServ.Location = new Point(509, 264);
            btnUpdateServ.Name = "btnUpdateServ";
            btnUpdateServ.Size = new Size(150, 35);
            btnUpdateServ.TabIndex = 5;
            btnUpdateServ.Text = "Actualizar";
            btnUpdateServ.UseVisualStyleBackColor = false;
            btnUpdateServ.Click += btnUpdateServ_Click;
            // 
            // btnAddServicio
            // 
            btnAddServicio.BackColor = Color.FromArgb(255, 128, 0);
            btnAddServicio.FlatStyle = FlatStyle.Flat;
            btnAddServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddServicio.ForeColor = SystemColors.ButtonHighlight;
            btnAddServicio.Location = new Point(277, 264);
            btnAddServicio.Name = "btnAddServicio";
            btnAddServicio.Size = new Size(150, 35);
            btnAddServicio.TabIndex = 4;
            btnAddServicio.Text = "Agregar";
            btnAddServicio.UseVisualStyleBackColor = false;
            btnAddServicio.Click += btnAddServicio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            label2.Location = new Point(530, 133);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            label1.Location = new Point(349, 133);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtDescripServ
            // 
            txtDescripServ.Location = new Point(502, 191);
            txtDescripServ.Name = "txtDescripServ";
            txtDescripServ.Size = new Size(157, 27);
            txtDescripServ.TabIndex = 1;
            txtDescripServ.KeyPress += txtDescripServ_KeyPress;
            // 
            // txtNombreServ
            // 
            txtNombreServ.Location = new Point(316, 190);
            txtNombreServ.Name = "txtNombreServ";
            txtNombreServ.Size = new Size(140, 27);
            txtNombreServ.TabIndex = 0;
            txtNombreServ.KeyPress += txtNombreServ_KeyPress;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnDeleteCat);
            tabPage2.Controls.Add(btnUpdateCat);
            tabPage2.Controls.Add(btnAddCateg);
            tabPage2.Controls.Add(dgvCategoriaServicios);
            tabPage2.Controls.Add(txtDescripcionCateg);
            tabPage2.Controls.Add(txtNombreCategoria);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1178, 591);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Categorias  de Servicios";

            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCategoriaServicios
            // 
            dgvCategoriaServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoriaServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriaServicios.Dock = DockStyle.Bottom;
            dgvCategoriaServicios.Location = new Point(3, 356);
            dgvCategoriaServicios.Name = "dgvCategoriaServicios";
            dgvCategoriaServicios.RowHeadersWidth = 51;
            dgvCategoriaServicios.Size = new Size(1172, 232);
            dgvCategoriaServicios.TabIndex = 14;
            // 
            // btnDeleteCateg
            // 
            //btnDeleteCateg.Location = new Point(677, 237);
            //btnDeleteCateg.Name = "btnDeleteCateg";
            //btnDeleteCateg.Size = new Size(94, 29);
            //btnDeleteCateg.TabIndex = 13;
            //btnDeleteCateg.Text = "Eliminar";
            //btnDeleteCateg.UseVisualStyleBackColor = true;
            //// 
            //// btnUpdateCateg
            //// 
            //btnUpdateCateg.Location = new Point(526, 237);
            //btnUpdateCateg.Name = "btnUpdateCateg";
            //btnUpdateCateg.Size = new Size(94, 29);
            //btnUpdateCateg.TabIndex = 12;
            //btnUpdateCateg.Text = "Actualizar";
            //btnUpdateCateg.UseVisualStyleBackColor = true;
            // 
            // btnAddCateg
            // 
            btnAddCateg.Location = new Point(360, 237);
            btnAddCateg.Name = "btnAddCateg";
            btnAddCateg.Size = new Size(94, 29);
            btnAddCateg.TabIndex = 11;
            btnAddCateg.Text = "Agregar";
            btnAddCateg.UseVisualStyleBackColor = true;
            btnAddCateg.Click += btnAddCateg_Click;


            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            label3.Location = new Point(614, 103);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 19;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            label4.Location = new Point(439, 103);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // btnDeleteCat
            // 
            btnDeleteCat.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteCat.FlatStyle = FlatStyle.Flat;
            btnDeleteCat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteCat.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteCat.Location = new Point(751, 228);
            btnDeleteCat.Name = "btnDeleteCat";
            btnDeleteCat.Size = new Size(150, 35);
            btnDeleteCat.TabIndex = 17;
            btnDeleteCat.Text = "Eliminar";
            btnDeleteCat.UseVisualStyleBackColor = false;
            btnDeleteCat.Click += btnDeleteCat_Click;
            // 
            // btnUpdateCat
            // 
            btnUpdateCat.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateCat.FlatStyle = FlatStyle.Flat;
            btnUpdateCat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateCat.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateCat.Location = new Point(527, 228);
            btnUpdateCat.Name = "btnUpdateCat";
            btnUpdateCat.Size = new Size(150, 35);
            btnUpdateCat.TabIndex = 16;
            btnUpdateCat.Text = "Actualizar";
            btnUpdateCat.UseVisualStyleBackColor = false;
            btnUpdateCat.Click += btnUpdateCat_Click;
            // 
            // btnAddCateg
            // 
            btnAddCateg.BackColor = Color.FromArgb(255, 128, 0);
            btnAddCateg.FlatStyle = FlatStyle.Flat;
            btnAddCateg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddCateg.ForeColor = SystemColors.ButtonHighlight;
            btnAddCateg.Location = new Point(295, 228);
            btnAddCateg.Name = "btnAddCateg";
            btnAddCateg.Size = new Size(150, 35);
            btnAddCateg.TabIndex = 15;
            btnAddCateg.Text = "Agregar";
            btnAddCateg.UseVisualStyleBackColor = false;
            btnAddCateg.Click += btnAddCateg_Click_1;
            // 
            // dgvCategoriaServicios
            // 
            dgvCategoriaServicios.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCategoriaServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriaServicios.Dock = DockStyle.Bottom;
            dgvCategoriaServicios.Location = new Point(3, 356);
            dgvCategoriaServicios.Name = "dgvCategoriaServicios";
            dgvCategoriaServicios.RowHeadersWidth = 51;
            dgvCategoriaServicios.Size = new Size(1172, 232);
            dgvCategoriaServicios.TabIndex = 14;
            dgvCategoriaServicios.CellClick += dgvCategoriaServicios_CellClick;
            // 
            // txtDescripcionCateg
            // 
            txtDescripcionCateg.Location = new Point(597, 165);
            txtDescripcionCateg.Name = "txtDescripcionCateg";
            txtDescripcionCateg.Size = new Size(125, 27);
            txtDescripcionCateg.TabIndex = 8;
            txtDescripcionCateg.KeyPress += txtDescripcionCateg_KeyPress;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(421, 165);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(125, 27);
            txtNombreCategoria.TabIndex = 7;
            txtNombreCategoria.KeyPress += txtNombreCategoria_KeyPress;
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 648);
            Controls.Add(tabControl1);
            Name = "Servicios";
            Text = "Servicios";
            Load += Servicios_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriaServicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox txtDescripServ;
        private TextBox txtNombreServ;
        private TabPage tabPage2;
        private DataGridView dgvServicios;
        private Button btnDeleteServ;
        private Button btnUpdateServ;
        private Button btnAddServicio;
        private Label label2;
        private DataGridView dgvCategoriaServicios;
        private TextBox txtDescripcionCateg;
        private TextBox txtNombreCategoria;
        private Label label5;
        private ComboBox cboCategoria;
        private Label label3;
        private Label label4;
        private Button btnDeleteCat;
        private Button btnUpdateCat;
        private Button btnAddCateg;
    }
}
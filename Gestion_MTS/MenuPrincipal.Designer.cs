namespace Gestion_MTS
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            BarraTitulo = new Panel();
            btnVentana = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            btnFactura = new Button();
            panel3 = new Panel();
            btnEmpleados = new Button();
            panel2 = new Panel();
            btnInventario = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(255, 89, 0);
            BarraTitulo.Controls.Add(btnVentana);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.ForeColor = SystemColors.ControlLight;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 62);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnVentana
            // 
            btnVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVentana.Cursor = Cursors.Hand;
            btnVentana.Image = (Image)resources.GetObject("btnVentana.Image");
            btnVentana.Location = new Point(1126, 12);
            btnVentana.Name = "btnVentana";
            btnVentana.Size = new Size(35, 35);
            btnVentana.SizeMode = PictureBoxSizeMode.Zoom;
            btnVentana.TabIndex = 3;
            btnVentana.TabStop = false;
            btnVentana.Visible = false;
            btnVentana.Click += btnVentana_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1191, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 35);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1126, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(35, 35);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1253, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 35);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(255, 183, 125);
            MenuVertical.Controls.Add(btnFactura);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnEmpleados);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(btnInventario);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 62);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 643);
            MenuVertical.TabIndex = 1;
            MenuVertical.Paint += MenuVertical_Paint;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.FromArgb(255, 183, 125);
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFactura.ForeColor = Color.Black;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btnFactura.Location = new Point(9, 324);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(208, 32);
            btnFactura.TabIndex = 5;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 89, 0);
            panel3.Location = new Point(0, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 32);
            panel3.TabIndex = 6;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(255, 183, 125);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.Black;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(9, 286);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(208, 32);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleado";
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 89, 0);
            panel2.Location = new Point(0, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 32);
            panel2.TabIndex = 4;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(255, 183, 125);
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.Black;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(9, 248);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(208, 32);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Productos";
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 89, 0);
            panel1.Location = new Point(0, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 32);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(64, 46, 32);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 62);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1080, 643);
            panelContenedor.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 705);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            Text = "ManuPrincipal";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnVentana;
        private PictureBox pictureBox1;
        private Button btnInventario;
        private Panel panel1;
        private Button btnFactura;
        private Panel panel3;
        private Button btnEmpleados;
        private Panel panel2;
    }
}
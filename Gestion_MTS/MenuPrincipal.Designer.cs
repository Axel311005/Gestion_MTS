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
            btnDesplegable = new PictureBox();
            btnVentana = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            SubMenuReportes = new Panel();
            panel7 = new Panel();
            btnReporteServicios = new Button();
            btnReporteVentas = new Button();
            panel6 = new Panel();
            btnReporte = new Button();
            panel4 = new Panel();
            btnFactura = new Button();
            panel3 = new Panel();
            btnEmpleados = new Button();
            panel2 = new Panel();
            btnInventario = new Button();
            panel1 = new Panel();
            ImageLogo = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDesplegable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            SubMenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageLogo).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(255, 89, 0);
            BarraTitulo.Controls.Add(btnDesplegable);
            BarraTitulo.Controls.Add(btnVentana);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.ForeColor = SystemColors.ControlLight;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 56);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnDesplegable
            // 
            btnDesplegable.Cursor = Cursors.Hand;
            btnDesplegable.Image = (Image)resources.GetObject("btnDesplegable.Image");
            btnDesplegable.Location = new Point(170, 12);
            btnDesplegable.Name = "btnDesplegable";
            btnDesplegable.Size = new Size(50, 36);
            btnDesplegable.SizeMode = PictureBoxSizeMode.Zoom;
            btnDesplegable.TabIndex = 10;
            btnDesplegable.TabStop = false;
            btnDesplegable.Click += btnDesplegable_Click;
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
            MenuVertical.Controls.Add(SubMenuReportes);
            MenuVertical.Controls.Add(btnReporte);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnFactura);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnEmpleados);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(btnInventario);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(ImageLogo);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 56);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 649);
            MenuVertical.TabIndex = 1;
            // 
            // SubMenuReportes
            // 
            SubMenuReportes.Controls.Add(panel7);
            SubMenuReportes.Controls.Add(btnReporteServicios);
            SubMenuReportes.Controls.Add(btnReporteVentas);
            SubMenuReportes.Controls.Add(panel6);
            SubMenuReportes.Location = new Point(26, 400);
            SubMenuReportes.Name = "SubMenuReportes";
            SubMenuReportes.Size = new Size(194, 81);
            SubMenuReportes.TabIndex = 9;
            SubMenuReportes.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 89, 0);
            panel7.Location = new Point(3, 41);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 32);
            panel7.TabIndex = 6;
            // 
            // btnReporteServicios
            // 
            btnReporteServicios.BackColor = Color.FromArgb(255, 183, 125);
            btnReporteServicios.FlatAppearance.BorderSize = 0;
            btnReporteServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnReporteServicios.FlatStyle = FlatStyle.Flat;
            btnReporteServicios.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteServicios.ForeColor = Color.Black;
            btnReporteServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteServicios.Location = new Point(12, 41);
            btnReporteServicios.Name = "btnReporteServicios";
            btnReporteServicios.Size = new Size(179, 32);
            btnReporteServicios.TabIndex = 5;
            btnReporteServicios.Text = "Reporte Servicios";
            btnReporteServicios.UseVisualStyleBackColor = false;
            btnReporteServicios.Click += btnReporteServicios_Click;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.BackColor = Color.FromArgb(255, 183, 125);
            btnReporteVentas.FlatAppearance.BorderSize = 0;
            btnReporteVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteVentas.ForeColor = Color.Black;
            btnReporteVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteVentas.Location = new Point(12, 3);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Size = new Size(179, 32);
            btnReporteVentas.TabIndex = 3;
            btnReporteVentas.Text = "Reporte Ventas";
            btnReporteVentas.UseVisualStyleBackColor = false;
            btnReporteVentas.Click += btnReporteVentas_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 89, 0);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 32);
            panel6.TabIndex = 4;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(255, 183, 125);
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporte.ForeColor = Color.Black;
            btnReporte.Image = (Image)resources.GetObject("btnReporte.Image");
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(9, 362);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(208, 32);
            btnReporte.TabIndex = 7;
            btnReporte.Text = "Reportes";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 89, 0);
            panel4.Location = new Point(0, 362);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 32);
            panel4.TabIndex = 8;
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
            // ImageLogo
            // 
            ImageLogo.Image = (Image)resources.GetObject("ImageLogo.Image");
            ImageLogo.Location = new Point(3, -2);
            ImageLogo.Name = "ImageLogo";
            ImageLogo.Size = new Size(217, 219);
            ImageLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ImageLogo.TabIndex = 0;
            ImageLogo.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(64, 46, 32);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 56);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1080, 649);
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
            ((System.ComponentModel.ISupportInitialize)btnDesplegable).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            SubMenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageLogo).EndInit();
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
        private PictureBox ImageLogo;
        private Button btnInventario;
        private Panel panel1;
        private Button btnFactura;
        private Panel panel3;
        private Button btnEmpleados;
        private Panel panel2;
        private Button btnReporte;
        private Panel panel4;
        private Panel SubMenuReportes;
        private Button btnReporteVentas;
        private Panel panel6;
        private Panel panel7;
        private Button btnReporteServicios;
        private PictureBox btnDesplegable;
    }
}
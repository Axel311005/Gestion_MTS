namespace Gestion_MTS
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelMenu = new Panel();
            btnSucursales = new Button();
            btnArqueo = new Button();
            SubMenuReportes = new Panel();
            btnReporteServicios = new Button();
            btnReporteVentas = new Button();
            btnReporte = new Button();
            btnFactura = new Button();
            btnEmpleados = new Button();
            btnInventario = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnVentana = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            btnServicios = new Button();
            panelMenu.SuspendLayout();
            SubMenuReportes.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnServicios);
            panelMenu.Controls.Add(btnSucursales);
            panelMenu.Controls.Add(btnArqueo);
            panelMenu.Controls.Add(SubMenuReportes);
            panelMenu.Controls.Add(btnReporte);
            panelMenu.Controls.Add(btnFactura);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 747);
            panelMenu.TabIndex = 0;
            // 
            // btnSucursales
            // 
            btnSucursales.BackColor = Color.Transparent;
            btnSucursales.FlatAppearance.BorderSize = 0;
            btnSucursales.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnSucursales.FlatStyle = FlatStyle.Flat;
            btnSucursales.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSucursales.ForeColor = Color.White;
            btnSucursales.Image = (Image)resources.GetObject("btnSucursales.Image");
            btnSucursales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSucursales.Location = new Point(0, 414);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(220, 60);
            btnSucursales.TabIndex = 14;
            btnSucursales.Text = "Sucursales";
            btnSucursales.UseVisualStyleBackColor = false;
            btnSucursales.Click += btnSucursales_Click;
            // 
            // btnArqueo
            // 
            btnArqueo.BackColor = Color.Transparent;
            btnArqueo.FlatAppearance.BorderSize = 0;
            btnArqueo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnArqueo.FlatStyle = FlatStyle.Flat;
            btnArqueo.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArqueo.ForeColor = Color.White;
            btnArqueo.Image = (Image)resources.GetObject("btnArqueo.Image");
            btnArqueo.ImageAlign = ContentAlignment.MiddleLeft;
            btnArqueo.Location = new Point(0, 344);
            btnArqueo.Name = "btnArqueo";
            btnArqueo.Size = new Size(220, 60);
            btnArqueo.TabIndex = 13;
            btnArqueo.Text = "Arqueo de Caja";
            btnArqueo.UseVisualStyleBackColor = false;
            btnArqueo.Click += btnArqueo_Click;
            // 
            // SubMenuReportes
            // 
            SubMenuReportes.Controls.Add(btnReporteServicios);
            SubMenuReportes.Controls.Add(btnReporteVentas);
            SubMenuReportes.Location = new Point(26, 552);
            SubMenuReportes.Name = "SubMenuReportes";
            SubMenuReportes.Size = new Size(194, 81);
            SubMenuReportes.TabIndex = 12;
            SubMenuReportes.Visible = false;
            // 
            // btnReporteServicios
            // 
            btnReporteServicios.BackColor = Color.Transparent;
            btnReporteServicios.FlatAppearance.BorderSize = 0;
            btnReporteServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnReporteServicios.FlatStyle = FlatStyle.Flat;
            btnReporteServicios.Font = new Font("Sans Serif Collection", 5.99999952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteServicios.ForeColor = Color.White;
            btnReporteServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteServicios.Location = new Point(3, 41);
            btnReporteServicios.Name = "btnReporteServicios";
            btnReporteServicios.Size = new Size(188, 32);
            btnReporteServicios.TabIndex = 5;
            btnReporteServicios.Text = "Reporte Servicios";
            btnReporteServicios.UseVisualStyleBackColor = false;
            btnReporteServicios.Click += btnReporteServicios_Click;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.BackColor = Color.Transparent;
            btnReporteVentas.FlatAppearance.BorderSize = 0;
            btnReporteVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Sans Serif Collection", 5.99999952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteVentas.ForeColor = Color.White;
            btnReporteVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteVentas.Location = new Point(3, 3);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Size = new Size(188, 32);
            btnReporteVentas.TabIndex = 3;
            btnReporteVentas.Text = "Reporte Ventas";
            btnReporteVentas.UseVisualStyleBackColor = false;
            btnReporteVentas.Click += btnReporteVentas_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.Transparent;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporte.ForeColor = Color.White;
            btnReporte.Image = (Image)resources.GetObject("btnReporte.Image");
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(0, 495);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(220, 60);
            btnReporte.TabIndex = 11;
            btnReporte.Text = "Reportes";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.Transparent;
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFactura.ForeColor = Color.White;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btnFactura.Location = new Point(0, 283);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(220, 60);
            btnFactura.TabIndex = 10;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(0, 217);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(220, 60);
            btnEmpleados.TabIndex = 9;
            btnEmpleados.Text = "Empleado";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Transparent;
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 80);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(220, 60);
            btnInventario.TabIndex = 8;
            btnInventario.Text = "Productos";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 5.99999952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 0;
            label1.Text = "Moto Servicios Terry";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnVentana);
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(btnMaximizar);
            panelTitleBar.Controls.Add(btnCerrar);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1110, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown_1;
            // 
            // btnVentana
            // 
            btnVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVentana.Cursor = Cursors.Hand;
            btnVentana.Image = (Image)resources.GetObject("btnVentana.Image");
            btnVentana.Location = new Point(962, 13);
            btnVentana.Name = "btnVentana";
            btnVentana.Size = new Size(35, 35);
            btnVentana.SizeMode = PictureBoxSizeMode.Zoom;
            btnVentana.TabIndex = 7;
            btnVentana.TabStop = false;
            btnVentana.Visible = false;
            btnVentana.Click += btnVentana_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1013, 13);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 35);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(962, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(35, 35);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 5;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1063, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 35);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 4;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(94, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(447, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(89, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1110, 667);
            panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1110, 667);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnServicios
            // 
            btnServicios.BackColor = Color.Transparent;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServicios.ForeColor = Color.White;
            btnServicios.Image = (Image)resources.GetObject("btnServicios.Image");
            btnServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicios.Location = new Point(0, 146);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(220, 60);
            btnServicios.TabIndex = 15;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 747);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 500);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            panelMenu.ResumeLayout(false);
            SubMenuReportes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnReporte;
        private Button btnFactura;
        private Button btnEmpleados;
        private Button btnInventario;
        private Panel SubMenuReportes;
        private Button btnReporteServicios;
        private Button btnReporteVentas;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Button btnCloseChildForm;
        private PictureBox btnVentana;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private Button btnArqueo;
        private Button btnSucursales;
        private Button btnServicios;
    }
}
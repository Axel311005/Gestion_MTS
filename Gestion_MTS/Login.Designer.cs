namespace Gestion_MTS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnlHeader = new Panel();
            btnMinimizar = new PictureBox();
            btnResize = new PictureBox();
            btnCerrar = new PictureBox();
            btnSeePass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSeePass).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.FromArgb(51, 41, 46);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.DarkOrange;
            btnIngresar.Location = new Point(155, 336);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Padding = new Padding(0, 8, 0, 8);
            btnIngresar.Size = new Size(257, 48);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ButtonFace;
            lblUserName.Location = new Point(155, 210);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(61, 16);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Location = new Point(155, 229);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(257, 23);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(155, 286);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';

            txtPassword.Size = new Size(229, 23);

            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(155, 267);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 16);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnMinimizar);
            pnlHeader.Controls.Add(btnResize);
            pnlHeader.Controls.Add(btnCerrar);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(606, 47);
            pnlHeader.TabIndex = 12;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(517, 10);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 26);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 14;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnResize
            // 
            btnResize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResize.Cursor = Cursors.Hand;
            btnResize.Image = (Image)resources.GetObject("btnResize.Image");
            btnResize.Location = new Point(472, 10);
            btnResize.Margin = new Padding(3, 2, 3, 2);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(31, 26);
            btnResize.SizeMode = PictureBoxSizeMode.Zoom;
            btnResize.TabIndex = 13;
            btnResize.TabStop = false;
            btnResize.Click += btnResize_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(561, 10);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 26);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnSeePass
            // 
            btnSeePass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeePass.Cursor = Cursors.Hand;
            btnSeePass.Image = (Image)resources.GetObject("btnSeePass.Image");

            btnSeePass.Location = new Point(390, 286);

            btnSeePass.Margin = new Padding(3, 2, 3, 2);
            btnSeePass.Name = "btnSeePass";
            btnSeePass.Size = new Size(22, 23);
            btnSeePass.SizeMode = PictureBoxSizeMode.Zoom;
            btnSeePass.TabIndex = 14;
            btnSeePass.TabStop = false;
            btnSeePass.Click += btnSeePass_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);

            ClientSize = new Size(606, 450);

            Controls.Add(btnSeePass);
            Controls.Add(pnlHeader);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSeePass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnIngresar;
        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblPassword;
        private Panel pnlHeader;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox btnResize;
        private PictureBox btnSeePass;
    }
}
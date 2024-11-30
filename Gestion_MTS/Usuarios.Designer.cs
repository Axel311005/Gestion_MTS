namespace Gestion_MTS
{
    partial class Usuarios
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblEmployeeId = new Label();
            cmbEmployeeId = new ComboBox();
            btnCreateUser = new Button();
            dgvUsers = new DataGridView();
            btnUpdate = new Button();
            txtNewPass = new TextBox();
            lblNewPass = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(130, 60);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(110, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Nombre de Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Location = new Point(130, 78);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(121, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(130, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(289, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(130, 118);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.Anchor = AnchorStyles.None;
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(298, 60);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(60, 15);
            lblEmployeeId.TabIndex = 4;
            lblEmployeeId.Text = "Empleado";
            // 
            // cmbEmployeeId
            // 
            cmbEmployeeId.Anchor = AnchorStyles.None;
            cmbEmployeeId.FormattingEnabled = true;
            cmbEmployeeId.Location = new Point(298, 78);
            cmbEmployeeId.Name = "cmbEmployeeId";
            cmbEmployeeId.Size = new Size(121, 23);
            cmbEmployeeId.TabIndex = 5;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Anchor = AnchorStyles.None;
            btnCreateUser.Location = new Point(130, 231);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(87, 39);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Crear usuario";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Bottom;
            dgvUsers.Location = new Point(0, 300);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(563, 150);
            dgvUsers.TabIndex = 7;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Location = new Point(238, 231);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 39);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.Location = new Point(130, 190);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(289, 23);
            txtNewPass.TabIndex = 10;
            txtNewPass.Visible = false;
            // 
            // lblNewPass
            // 
            lblNewPass.Anchor = AnchorStyles.None;
            lblNewPass.AutoSize = true;
            lblNewPass.Location = new Point(130, 172);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(104, 15);
            lblNewPass.TabIndex = 9;
            lblNewPass.Text = "Nueva Contraseña";
            lblNewPass.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.Location = new Point(334, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 39);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtNewPass);
            Controls.Add(lblNewPass);
            Controls.Add(btnUpdate);
            Controls.Add(dgvUsers);
            Controls.Add(btnCreateUser);
            Controls.Add(cmbEmployeeId);
            Controls.Add(lblEmployeeId);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblEmployeeId;
        private ComboBox cmbEmployeeId;
        private Button btnCreateUser;
        private DataGridView dgvUsers;
        private Button btnUpdate;
        private TextBox txtNewPass;
        private Label lblNewPass;
        private Button btnDelete;
    }
}
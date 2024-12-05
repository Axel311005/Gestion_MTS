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
            lblUserName.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(149, 80);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(146, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Nombre de Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Location = new Point(149, 104);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(138, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(149, 181);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 27);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(149, 157);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.Anchor = AnchorStyles.None;
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            lblEmployeeId.Location = new Point(341, 80);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(78, 20);
            lblEmployeeId.TabIndex = 4;
            lblEmployeeId.Text = "Empleado";
            // 
            // cmbEmployeeId
            // 
            cmbEmployeeId.Anchor = AnchorStyles.None;
            cmbEmployeeId.FormattingEnabled = true;
            cmbEmployeeId.Location = new Point(341, 104);
            cmbEmployeeId.Margin = new Padding(3, 4, 3, 4);
            cmbEmployeeId.Name = "cmbEmployeeId";
            cmbEmployeeId.Size = new Size(138, 28);
            cmbEmployeeId.TabIndex = 5;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Anchor = AnchorStyles.None;
            btnCreateUser.BackColor = Color.FromArgb(255, 128, 0);
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateUser.ForeColor = SystemColors.ButtonHighlight;
            btnCreateUser.Location = new Point(45, 307);
            btnCreateUser.Margin = new Padding(3, 4, 3, 4);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(159, 52);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Crear usuario";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Bottom;
            dgvUsers.Location = new Point(0, 400);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(643, 200);
            dgvUsers.TabIndex = 7;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(239, 307);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 52);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.Location = new Point(149, 253);
            txtNewPass.Margin = new Padding(3, 4, 3, 4);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(330, 27);
            txtNewPass.TabIndex = 10;
            txtNewPass.Visible = false;
            // 
            // lblNewPass
            // 
            lblNewPass.Anchor = AnchorStyles.None;
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            lblNewPass.Location = new Point(149, 229);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(139, 20);
            lblNewPass.TabIndex = 9;
            lblNewPass.Text = "Nueva Contraseña";
            lblNewPass.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(427, 307);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 52);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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
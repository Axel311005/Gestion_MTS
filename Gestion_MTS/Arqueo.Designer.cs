namespace Gestion_MTS
{
    partial class Arqueo
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
            dgvGastosDiarios = new DataGridView();
            cbSucursales = new ComboBox();
            dtpFechaFiltroGasto = new DateTimePicker();
            ObtenerGastos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGastosDiarios).BeginInit();
            SuspendLayout();
            // 
            // dgvGastosDiarios
            // 
            dgvGastosDiarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosDiarios.Location = new Point(312, 275);
            dgvGastosDiarios.Name = "dgvGastosDiarios";
            dgvGastosDiarios.RowHeadersWidth = 51;
            dgvGastosDiarios.Size = new Size(448, 274);
            dgvGastosDiarios.TabIndex = 0;
            // 
            // cbSucursales
            // 
            cbSucursales.FormattingEnabled = true;
            cbSucursales.Location = new Point(312, 139);
            cbSucursales.Name = "cbSucursales";
            cbSucursales.Size = new Size(151, 28);
            cbSucursales.TabIndex = 1;
            // 
            // dtpFechaFiltroGasto
            // 
            dtpFechaFiltroGasto.Location = new Point(510, 140);
            dtpFechaFiltroGasto.Name = "dtpFechaFiltroGasto";
            dtpFechaFiltroGasto.Size = new Size(250, 27);
            dtpFechaFiltroGasto.TabIndex = 2;
            // 
            // ObtenerGastos
            // 
            ObtenerGastos.Location = new Point(413, 217);
            ObtenerGastos.Name = "ObtenerGastos";
            ObtenerGastos.Size = new Size(246, 29);
            ObtenerGastos.TabIndex = 3;
            ObtenerGastos.Text = "Obtener";
            ObtenerGastos.UseVisualStyleBackColor = true;
            ObtenerGastos.Click += ObtenerGastos_Click;
            // 
            // Arqueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 620);
            Controls.Add(ObtenerGastos);
            Controls.Add(dtpFechaFiltroGasto);
            Controls.Add(cbSucursales);
            Controls.Add(dgvGastosDiarios);
            Name = "Arqueo";
            Text = "Arqueo";
            Load += Arqueo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGastosDiarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGastosDiarios;
        private ComboBox cbSucursales;
        private DateTimePicker dtpFechaFiltroGasto;
        private Button ObtenerGastos;
    }
}
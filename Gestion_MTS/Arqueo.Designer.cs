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
            cboSucursales = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            ObtenerGastos = new Button();
            dtpFechaFinal = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // cboSucursales
            // 
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(106, 142);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(151, 28);
            cboSucursales.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(379, 143);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 2;
            // 
            // ObtenerGastos
            // 
            ObtenerGastos.BackColor = Color.FromArgb(255, 128, 0);
            ObtenerGastos.FlatStyle = FlatStyle.Flat;
            ObtenerGastos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ObtenerGastos.ForeColor = SystemColors.ButtonHighlight;
            ObtenerGastos.Location = new Point(383, 258);
            ObtenerGastos.Name = "ObtenerGastos";
            ObtenerGastos.Size = new Size(246, 35);
            ObtenerGastos.TabIndex = 3;
            ObtenerGastos.Text = "Obtener";
            ObtenerGastos.UseVisualStyleBackColor = false;
            ObtenerGastos.Click += ObtenerGastos_Click;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(715, 143);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(250, 27);
            dtpFechaFinal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(105, 94);
            label1.Name = "label1";
            label1.Size = new Size(142, 26);
            label1.TabIndex = 5;
            label1.Text = "Sucursales";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(431, 94);
            label2.Name = "label2";
            label2.Size = new Size(159, 26);
            label2.TabIndex = 6;
            label2.Text = "Fecha Inicio";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(755, 94);
            label3.Name = "label3";
            label3.Size = new Size(150, 26);
            label3.TabIndex = 7;
            label3.Text = "Fecha Final";
            label3.Click += this.label3_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(412, 340);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(194, 27);
            txtTotal.TabIndex = 8;
            // 
            // Arqueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 626);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFechaFinal);
            Controls.Add(ObtenerGastos);
            Controls.Add(dtpFechaInicio);
            Controls.Add(cboSucursales);
            Name = "Arqueo";
            Text = "Arqueo";
            Load += Arqueo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboSucursales;
        private DateTimePicker dtpFechaInicio;
        private Button ObtenerGastos;
        private DateTimePicker dtpFechaFinal;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTotal;
    }
}
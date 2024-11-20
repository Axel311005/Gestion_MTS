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
            cboSucursales.Location = new Point(180, 142);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(151, 28);
            cboSucursales.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(409, 143);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 2;
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
            label1.Location = new Point(216, 97);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "Sucursales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 97);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(796, 97);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 7;
            label3.Text = "Fecha Final";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(472, 328);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 8;
            // 
            // Arqueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 620);
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
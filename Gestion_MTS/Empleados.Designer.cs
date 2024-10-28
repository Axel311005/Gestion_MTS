namespace Gestion_MTS
{
    partial class Empleados
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
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Dock = DockStyle.Bottom;
            dgvEmpleados.GridColor = SystemColors.MenuHighlight;
            dgvEmpleados.Location = new Point(0, 263);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(800, 187);
            dgvEmpleados.TabIndex = 0;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEmpleados);
            Name = "Empleados";
            Text = "Gestión Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
    }
}
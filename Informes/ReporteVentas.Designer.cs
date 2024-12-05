namespace Informes
{
    partial class ReporteVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mTS_TerryDataSet = new Informes.MTS_TerryDataSet();
            this.mTSTerryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasEmpleadoTableAdapter = new Informes.MTS_TerryDataSetTableAdapters.VentasEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mTS_TerryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTSTerryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasEmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ventasEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Informes.Ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1137, 651);
            this.reportViewer1.TabIndex = 0;
            // 
            // mTS_TerryDataSet
            // 
            this.mTS_TerryDataSet.DataSetName = "MTS_TerryDataSet";
            this.mTS_TerryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mTSTerryDataSetBindingSource
            // 
            this.mTSTerryDataSetBindingSource.DataSource = this.mTS_TerryDataSet;
            this.mTSTerryDataSetBindingSource.Position = 0;
            // 
            // ventasEmpleadoBindingSource
            // 
            this.ventasEmpleadoBindingSource.DataMember = "VentasEmpleado";
            this.ventasEmpleadoBindingSource.DataSource = this.mTS_TerryDataSet;
            // 
            // ventasEmpleadoTableAdapter
            // 
            this.ventasEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 651);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mTS_TerryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTSTerryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasEmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mTSTerryDataSetBindingSource;
        private MTS_TerryDataSet mTS_TerryDataSet;
        private System.Windows.Forms.BindingSource ventasEmpleadoBindingSource;
        private MTS_TerryDataSetTableAdapters.VentasEmpleadoTableAdapter ventasEmpleadoTableAdapter;
    }
}


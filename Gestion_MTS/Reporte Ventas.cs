using Gestion_MTS.IRepository.Repository;
using Gestion_MTS.Vistas;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestion_MTS
{
    public partial class frmReporteVentas : Form
    {
        private string _connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            BindingList<VistaVentasEmpleados> employeesSells = new BindingList<VistaVentasEmpleados>();

            EmpleadoRepository empleadoRepository = new EmpleadoRepository(_connection);

            foreach(VistaVentasEmpleados employeeSells in empleadoRepository.GetEmployeeSells())
            {
                employeesSells.Add(employeeSells);
            }

            CategoryAxisDataBindModel dataSeriesModel = new CategoryAxisDataBindModel(employeesSells);

            dataSeriesModel.CategoryName = "MesVenta";

            dataSeriesModel.YNames = new string[] { "TotalVentas" };

            ChartSeries chartSeries = new ChartSeries("TotalVentas");

            chartSeries.CategoryModel = dataSeriesModel;

            //chartControl1.PrimaryXAxis.ValueType = ChartValueType.Category;

            //this.chartControl1.Skins = Skins.Metro;
        }
    }
}

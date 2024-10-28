using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_MTS
{
    public partial class Empleados : Form
    {

        private string connectionString = "Server=DESKTOP-G25OVJH\\SQLEXPRESS;Database=MTS_Terry;Integrated Security=True;";
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Refresh();
            TestConnection();
        }

        private void Refresh()
        {
            try
            {
                MTS_TerryDB db = new MTS_TerryDB();
                var empleados = db.GetEmpleados(); // Almacena en una variable

                if (empleados.Count > 0)
                {
                    dgvEmpleados.DataSource = empleados; // Asigna solo si hay empleados
                    MessageBox.Show("Yes");
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }

    }
}

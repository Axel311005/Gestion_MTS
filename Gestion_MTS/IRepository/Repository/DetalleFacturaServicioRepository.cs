using Gestion_MTS.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.IRepository.Repository
{
    public class DetalleFacturaServicioRepository : IRepository<DetalleFacturaServicio>
    {
        private readonly string _connectionString;

        public DetalleFacturaServicioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(DetalleFacturaServicio ado)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(DetalleFacturaServicio ado, int id)
        {
            throw new NotImplementedException();
        }

        public void MultipleInsert(DataTable facturaServicesDetails)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {

                    connection.Open();

                    using (var bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = "detalle_factura_servicio";
                        bulkCopy.WriteToServer(facturaServicesDetails);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    $"Ocurrio un error : {e.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

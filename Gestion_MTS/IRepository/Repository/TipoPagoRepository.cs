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
    public class TipoPagoRepository : IRepository<TipoPago>
    {
        private readonly string _connectionString;

        public TipoPagoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(TipoPago ado)
        {
            string query = "insert into tiposPago(tipo) values (@tipo)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@tipo", ado.Tipo);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    throw new Exception("Error al insertar: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM tiposPago WHERE id_tipo_pago = @id_tipo_pago";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@id_tipo_pago", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
        }

        public DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT tipo FROM tiposPago";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(tabla);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return tabla;
        }

        public void Update(TipoPago ado, int id)
        {
            string query = "UPDATE tiposPago SET tipo = @tipo where id_tipo_pago = @id_tipo_pago";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@tipo", ado.Tipo);
                command.Parameters.AddWithValue("@id_tipo_pago", ado.IdTipoPago);
              

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar : " + e.Message);
                }
            }
        }
    }
}

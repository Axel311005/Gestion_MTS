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
    public class BodegaRepository : IRepository<Bodega>
    {
        private readonly string _connectionString;

        public BodegaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Bodega bodega)
        {
            string query = "insert into bodegas(nombre,id_sucursal) values (@nombre, @sucursal)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", bodega.nombre);
                command.Parameters.AddWithValue("@sucursal", bodega.id_sucursal);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    throw new Exception("Error al insertar la bodega: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM bodegas WHERE id_bodega = @id_bodega";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@id_bodega", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró la bodega con el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al eliminar la bodega: " + e.Message);
                }
            }
        }

        public DataTable GetAll()
        {
           
            DataTable bodegas = new DataTable();
            string query = "SELECT * FROM BodegasView";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(bodegas);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return bodegas;
        }

        public void Update(Bodega bodega, int id)
        {
            string query = "UPDATE bodegas SET nombre = @nombre, id_sucursal = @id_sucursal WHERE id_bodega = @id_bodega";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@nombre", bodega.nombre);
                command.Parameters.AddWithValue("@id_sucursal", bodega.id_sucursal);
                command.Parameters.AddWithValue("@id_bodega", bodega.id_bodega);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró la bodega con el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar la bodega: " + e.Message);
                }
            }
        }

        public int? GetIdBodega(string bodega)
        {

            string query = "Select TOP 1 id_bodega from bodegas where nombre = @bodega";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@bodega", bodega);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    // Si el resultado no es nulo, convierte el valor a int y devuélvelo
                    if (result != null && int.TryParse(result.ToString(), out int idBodega))
                    {
                        return idBodega;
                    }
                    else
                    {
                        return null; // Si no hay resultados, devuelve null
                    }



                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }

            }


        }

        public List<string> GetNombreBodega()
        {
            List<string> bodegas = new List<string>();
            string query = "SELECT nombre FROM bodegas";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bodegas.Add(reader["nombre"].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }

            return bodegas;
        }

    }
}

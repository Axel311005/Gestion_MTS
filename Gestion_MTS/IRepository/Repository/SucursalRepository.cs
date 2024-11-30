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
    public class SucursalRepository : IRepository<Sucursal>
    {

        private readonly string _connectionString;

        public SucursalRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Sucursal ado)
        {
            string query = "Insert into sucursales(ubicacion, telefono) values(@ubicacion , @telefono)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ubicacion", ado.ubicacion);
                command.Parameters.AddWithValue("@telefono", ado.telefono);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    throw new Exception("Error " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from sucursales where id_sucursal = @id_sucursal";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_sucursal", id);

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
                    throw new Exception("Error " + e.Message);
                }
            }
        }

        public DataTable GetAll()
        {
            DataTable sucursal = new DataTable();

            string query = "Select ubicacion from sucursales";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(sucursal);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return sucursal;
        }

        public void Update(Sucursal ado, int id)
        {
            string query = "Update sucursales SET ubicacion = @ubicacion, telefono = @telefono " +
                "WHERE id_sucursal = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ubicacion", ado.ubicacion);
                command.Parameters.AddWithValue("@telefono", ado.telefono);
                command.Parameters.AddWithValue("@id", id);

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
                    throw new Exception("Error " + e.Message);
                }
            }
        }

        public int? GetIdSucursal(string sucursal)
        {

            string query = "Select TOP 1 id_sucursal from sucursales where ubicacion = @sucursal";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@sucursal", sucursal);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    // Si el resultado no es nulo, convierte el valor a int y devuélvelo
                    if (result != null && int.TryParse(result.ToString(), out int idSucursal))
                    {
                        return idSucursal;
                    }
                    else
                    {
                        return null; 
                    }



                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }

            }


        }

        public List<string> GetUbicacionSucursal()
        {
            List<string> sucursales = new List<string>();

            string query = "SELECT ubicacion FROM sucursales";
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
                            // Agregar cada valor de la columna 'ubicacion' a la lista
                            sucursales.Add(reader["ubicacion"].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }

            return sucursales;
        }

    }
}

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
    public class RolRepository : IRepository<Rol>
    {
        private readonly string _connectionString;

        public RolRepository(string connectionString)
        {
            _connectionString = connectionString; ;
        }

        public void Add(Rol ado)
        {
            string query = "Insert into roles(nombre, descripcion) values(@nombre , @descripcion)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.nombre);
                command.Parameters.AddWithValue("@descripcion", ado.descripcion);

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
            string query = "Delete from roles where id_rol = @id_rol";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_rol", id);

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
            
            DataTable roles = new DataTable();
            string query = "SELECT id_rol ,nombre, descripcion FROM roles";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(roles);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return roles;
        }

        public void Update(Rol ado, int id)
        {
            string query = "Update roles SET nombre = @nombre , descripcion = @descripcion " +
                "WHERE id_rol = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.nombre);
                command.Parameters.AddWithValue("@descripcion", ado.descripcion);
                command.Parameters.AddWithValue("@id", ado.id_rol);

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

        public int? GetIdRol(string rol)
        {

            string query = "Select TOP 1 id_rol from roles where nombre = @roles";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@roles", rol);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
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

        public List<string> GetRoles()
        {
            List<string> roles = new List<string>();
            string query = "SELECT nombre FROM roles";

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
                            // Agregar cada valor de la columna 'nombre' a la lista
                            roles.Add(reader["nombre"].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }

            return roles;
        }

    }
}

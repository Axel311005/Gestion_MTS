using Gestion_MTS.Clases;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestion_MTS.IRepository.Repository
{
    public class UsuarioRepository : IRepository<Usuario>
    {

        private readonly string _connection;

        public UsuarioRepository(string db_connection)
        {
            this._connection = db_connection;
        }

        public void Add(Usuario ado)
        {
            string query = "INSERT INTO usuarios (nombre_usuario, id_empleado, contraseña)" +
                " VALUES (@userName, @employeeId, @password)";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@userName", ado.NombreUsuario);
                command.Parameters.AddWithValue("@employeeId", ado.IdEmpleado);
                command.Parameters.AddWithValue("@password", ado.Contraseña);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM usuarios WHERE id_usuario = @id_usuario";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@id_usuario", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ID especificado.");
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
            DataTable usuarios = new DataTable();

            string query = "Select u.id_usuario, u.nombre_usuario, (e.nombre + ' ' + e.apellido) AS pertenece FROM usuarios u " +
                "INNER JOIN empleados e ON u.id_empleado = e.id_empleado"; 
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(usuarios);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return usuarios;
        }

        public Usuario? GetByUserName(string userName) {
            Usuario user = new Usuario();

            string query = "SELECT * FROM usuarios WHERE nombre_usuario = @userName";
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@userName", userName);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.Read())
                    {
                        user.IdUsuario = reader.GetInt32(0);
                        user.NombreUsuario = reader.GetString(1);
                        user.IdEmpleado = reader.GetInt32(2);
                        user.Contraseña = reader.GetString(3);

                        return user;
                    }
                    
                    return null;
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
        }

        public int? GetUserRole(int userId)
        {
            string query = "SELECT r.id_rol FROM usuarios u " +
                "INNER JOIN empleados e ON u.id_empleado = e.id_empleado " +
                "INNER JOIN roles r ON e.id_rol = r.id_rol WHERE id_usuario = @userId";

            int role;

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        role = reader.GetInt32(0);
                        return role;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }

            return null;
        }

        public void Update(Usuario ado, int id)
        {
            string query;
             
            if(ado.Contraseña != null)
            {
                query = "UPDATE usuarios SET nombre_usuario = @nombre, contraseña = @pass, id_empleado = @idEmpleado" +
                " WHERE id_usuario = @id";
            } else
            {
                query = "UPDATE usuarios SET nombre_usuario = @nombre, id_empleado = @idEmpleado" +
                " WHERE id_usuario = @id";
            }

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.NombreUsuario);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idEmpleado", ado.IdEmpleado);

                if(ado.Contraseña != null)
                {
                    command.Parameters.AddWithValue("@pass", ado.Contraseña);
                }

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
    }
}

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
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
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

        public void Update(Usuario ado)
        {
            throw new NotImplementedException();
        }
    }
}

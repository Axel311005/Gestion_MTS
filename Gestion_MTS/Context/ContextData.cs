using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Context
{
    public class ContextData
    {
        public ContextData(int userId, int roleId)
        {
            this.userId = userId;
            this.roleId = roleId;
        }

        public int GetEmployeeId()
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            string query = @"
                SELECT e.id_empleado FROM usuarios u
                INNER JOIN empleados e ON u.id_empleado = e.id_empleado
                WHERE u.id_usuario = @userId;
            ";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", this.userId);

                try
                {
                    connection.Open();

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                    }

                    return 0;

                } catch(Exception e)
                {
                    return 0;
                }
            }
        }

        public int userId { get; set; }
        public int roleId { get; set; }
    }
}

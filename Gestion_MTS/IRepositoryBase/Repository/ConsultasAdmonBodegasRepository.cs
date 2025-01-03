﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.ConsultasAdo.Net
{
    public class ConsultasAdmonBodegas
    {

        private readonly string _connectionString;

        public ConsultasAdmonBodegas(string connectionString)
        {
            _connectionString = connectionString;
        }


        public List<string> GetSucursales()
        {
            List<string> listaSucursales = new List<string>();
            DataTable sucursales = new DataTable();
            string query = "SELECT ubicacion FROM sucursales";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(sucursales);

                    foreach (DataRow row in sucursales.Rows)
                    {
                        listaSucursales.Add(row["ubicacion"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return listaSucursales;
        }

        public List<string> GetBodegas()
        {
            List<string> lista = new List<string>();
            DataTable bodegas = new DataTable();
            string query = "SELECT nombre FROM bodegas";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(bodegas);

                    foreach (DataRow row in bodegas.Rows)
                    {
                        lista.Add(row["nombre"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return lista;
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

                    if (result != null && int.TryParse(result.ToString(), out int idBodega))
                    {
                        return idBodega;
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

        public void AddBodegas(string nombreBodega, int id_sucursal)
        {
            string query = "insert into bodegas(nombre,id_sucursal) values (@nombre, @sucursal)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", nombreBodega);
                command.Parameters.AddWithValue("@sucursal", id_sucursal);

                try
                {
                    connection.Open ();
                    command.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }

            }
        }
        public void AddLocalBodega(string descripcion, int id_bodega)
        {
            string query = "INSERT INTO localizacionesBodega(descripcion, id_bodega) VALUES (@descripcion, @idBodega)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@idBodega", id_bodega);

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
    }
    
}

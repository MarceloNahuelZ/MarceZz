using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _1ZabalettaMarceloTP7
{
    public class EmpleadosConexion
    {
        private string connectionString;

        public EmpleadosConexion(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void HabilitarIdentityInsert()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Empleados ON", connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al habilitar IDENTITY_INSERT: " + ex.Message);
            }
        }

        public void DeshabilitarIdentityInsert()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Empleados OFF", connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al deshabilitar IDENTITY_INSERT: " + ex.Message);
            }
        }

        public void AgregarEmpleado(Empleados empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "INSERT INTO Empleados (NombreCompleto, DNI, Edad, Casado, Salario) VALUES (@NombreCompleto, @DNI, @Edad, @Casado, @Salario)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@NombreCompleto", empleado.NombreCompleto);
                        cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                        cmd.Parameters.AddWithValue("@Edad", empleado.Edad);
                        cmd.Parameters.AddWithValue("@Casado", empleado.Casado);
                        cmd.Parameters.AddWithValue("@Salario", empleado.Salario);

                       
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al agregar el empleado: " + ex.Message);
            }
        }

        public List<Empleados> ObtenerListaEmpleados()
        {
            List<Empleados> listaEmpleados = new List<Empleados>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Empleados ORDER BY Salario";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               
                                int id = Convert.ToInt32(reader["ID"]);
                                string nombreCompleto = Convert.ToString(reader["NombreCompleto"]);
                                string dni = Convert.ToString(reader["DNI"]);
                                int edad = Convert.ToInt32(reader["Edad"]);
                                bool casado = Convert.ToBoolean(reader["Casado"]);
                                decimal salario = Convert.ToDecimal(reader["Salario"]);

                                
                                Empleados empleado = new Empleados
                                {
                                    Id = id,
                                    NombreCompleto = nombreCompleto,
                                    DNI = dni,
                                    Edad = edad,
                                    Casado = casado,
                                    Salario = salario
                                };

                               
                                listaEmpleados.Add(empleado);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
                throw new Exception("Error al obtener la lista de empleados: " + ex.Message);
            }

            return listaEmpleados;
        }
    }
}

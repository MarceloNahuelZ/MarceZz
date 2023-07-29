using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ZABALETTAMARCELO_TP7
{
    class EmpleadosConexion
    {
        private string connectionString;

        public EmpleadosConexion(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Empleados> ListarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("SELECT * FROM Empleados ORDER BY Salario", conexion))
            {
                conexion.Open();

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Empleados aux = new Empleados();
                        aux.NombreCompleto = lector.GetString(1);
                        aux.DNI = lector.GetString(2);
                        aux.Edad = lector.GetInt32(3);
                        aux.Casado = lector.GetBoolean(4);
                        aux.Salario = lector.GetDecimal(5);

                        lista.Add(aux);
                    }
                }
            }

            return lista;
        }
        
        
    }
}




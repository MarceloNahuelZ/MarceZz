using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPFINALZABALETTAMARCELO
{
    internal class EmpleadoConexion
    {
        public List<Empleados> listarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "Data Source=.;Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();


            try
            {
                while (lector.Read())
                {
                    Empleados aux = new Empleados();
                    aux.Id = lector.GetInt32(0);
                    aux.NombreCompleto = lector.GetString(1);
                    aux.DNI = lector.GetString(2);
                    aux.Edad = lector.GetInt32(3);
                    aux.Casado = lector.GetBoolean(4);
                    aux.Salario = lector.GetDecimal(5);

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return lista;
        }
        public void EliminarEmpleadoPorDNI(string dni)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=EMPLEADOS_DB;Integrated Security=True"))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("DELETE FROM Empleados WHERE DNI = @DNI", conexion);
                comando.Parameters.AddWithValue("@DNI", dni);
                comando.ExecuteNonQuery();
            }
        }
        public void ModificarEmpleado(string dniOriginal, string nombreCompleto, string nuevoDNI, int edad, bool casado, double salario)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=EMPLEADOS_DB;Integrated Security=True"))
            {
                string query = "UPDATE Empleados SET NombreCompleto = @NombreCompleto, DNI = @NuevoDNI, Edad = @Edad, Casado = @Casado, Salario = @Salario WHERE DNI = @DNIOriginal";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    comando.Parameters.AddWithValue("@NuevoDNI", nuevoDNI);
                    comando.Parameters.AddWithValue("@Edad", edad);
                    comando.Parameters.AddWithValue("@Casado", casado);
                    comando.Parameters.AddWithValue("@Salario", salario);
                    comando.Parameters.AddWithValue("@DNIOriginal", dniOriginal);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINALZABALETTAMARCELO
{
    public partial class NuevoEmpleado : Form
    {
        public NuevoEmpleado()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.Fill(this.eMPLEADOS_DBDataSet.Empleados);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombreCompleto.Text;
            string dni = txtDNI.Text;
            string edadText = txtEdad.Text;
            string casadoText = comboCasado.SelectedItem as string;
            string salarioText = txtSalario.Text;

            if (string.IsNullOrWhiteSpace(nombreCompleto) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(edadText) || string.IsNullOrWhiteSpace(casadoText) || string.IsNullOrWhiteSpace(salarioText))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(edadText, out int edad))
            {
                MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(salarioText, out double salario))
            {
                MessageBox.Show("El salario debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool casado = casadoText == "Si";

            InsertarEmpleado(nombreCompleto, dni, edad, casado, salario);
            MessageBox.Show("La carga ha sido exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
        }

        private void InsertarEmpleado(string nombreCompleto, string dni, int edad, bool casado, double salario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=EMPLEADOS_DB;Integrated Security=True"))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO Empleados (NombreCompleto, DNI, Edad, Casado, Salario) VALUES (@NombreCompleto, @DNI, @Edad, @Casado, @Salario)", conexion);
                    comando.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    comando.Parameters.AddWithValue("@DNI", dni);
                    comando.Parameters.AddWithValue("@Edad", edad);
                    comando.Parameters.AddWithValue("@Casado", casado);
                    comando.Parameters.AddWithValue("@Salario", salario);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar empleado: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salario_Click(object sender, EventArgs e)
        {

        }

        private void Casado_Click(object sender, EventArgs e)
        {

        }

        private void Edad_Click(object sender, EventArgs e)
        {

        }

        private void DNI_Click(object sender, EventArgs e)
        {

        }

        private void NyA_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ZabalettaMarceloTP7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string connectionString = "Data Source=.;Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            EmpleadosConexion conexion = new EmpleadosConexion(connectionString);

            try
            {
               
                List<Empleados> listaEmpleados = conexion.ObtenerListaEmpleados();

                
                dataEmpleados.DataSource = listaEmpleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEmpleados formularioEmpleados = new frmEmpleados();
            formularioEmpleados.ShowDialog();
        }

        private void dataEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

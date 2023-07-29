using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZABALETTAMARCELO_TP7
{
    public partial class Form1 : Form
    {
        private EmpleadosConexion conexion;

        public Form1()
        {
            InitializeComponent();

           
            string connectionString = Properties.Settings.Default.ConnectionString;
            conexion = new EmpleadosConexion(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dvgEmpleados.DataSource = conexion.ListarEmpleados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

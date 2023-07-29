using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ZabalettaMarceloTP7
{
    public partial class frmEmpleados : Form
    {
        private EmpleadosConexion conexion;

        public frmEmpleados()
        {
            InitializeComponent();

            
            string connectionString = connectionString = "Data Source=.;Initial Catalog=EMPLEADOS_DB;Integrated Security=True ";
            conexion = new EmpleadosConexion(connectionString);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            string nombreCompleto = txtNyA.Text;
            string dni = txtDni.Text;
            int edad = int.Parse(txtEdad.Text);
            bool casado = radioButton1.Checked;
            decimal salario = decimal.Parse(txtSalario.Text);

           
            Empleados nuevoEmpleado = new Empleados
            {
                NombreCompleto = nombreCompleto,
                DNI = dni,
                Edad = edad,
                Casado = casado,
                Salario = salario
            };

           
            conexion.HabilitarIdentityInsert();

           
            conexion.AgregarEmpleado(nuevoEmpleado);

           
            conexion.DeshabilitarIdentityInsert();

            this.Close();
        }

    }
}

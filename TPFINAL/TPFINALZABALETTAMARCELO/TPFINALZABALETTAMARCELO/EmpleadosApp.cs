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
    public partial class formEmpleados : Form
    {
        public formEmpleados()
        {
            InitializeComponent();

        }
      

        public void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            EmpleadoConexion conexion = new EmpleadoConexion();
            dgvEmpleados.DataSource = conexion.listarEmpleados();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEmpleado nuevoEmpleado = new NuevoEmpleado();
            nuevoEmpleado.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoConexion conexion = new EmpleadoConexion();
            dgvEmpleados.DataSource = conexion.listarEmpleados(); 
            dgvEmpleados.Invalidate(); 
        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                
                string dni = dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString();

                
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar al empleado con DNI " + dni + "?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    EmpleadoConexion conexion = new EmpleadoConexion();
                    conexion.EliminarEmpleadoPorDNI(dni);

                    
                    dgvEmpleados.DataSource = conexion.listarEmpleados();
                    dgvEmpleados.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string nombreFiltro = txtBuscar.Text.Trim(); 
            List<Empleados> empleadosFiltrados = new List<Empleados>();

           
            foreach (Empleados empleado in dgvEmpleados.DataSource as List<Empleados>)
            {
                if (empleado.NombreCompleto.ToLower().Contains(nombreFiltro.ToLower()))
                {
                    empleadosFiltrados.Add(empleado);
                }
              
            }

            dgvEmpleados.DataSource = empleadosFiltrados; 
            dgvEmpleados.Invalidate();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnFiltrar_Click(sender, e); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
               
                string nombreCompleto = dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString();
                string dni = dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString();
                int edad = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[2].Value);
                bool casado = Convert.ToBoolean(dgvEmpleados.SelectedRows[0].Cells[3].Value);
                double salario = Convert.ToDouble(dgvEmpleados.SelectedRows[0].Cells[4].Value);

                ModificarEmpleado modificarEmpleado = new ModificarEmpleado(nombreCompleto, dni, edad, casado, salario);

                if (modificarEmpleado.ShowDialog() == DialogResult.OK)
                {
                    
                    EmpleadoConexion conexion = new EmpleadoConexion();
                    dgvEmpleados.DataSource = conexion.listarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

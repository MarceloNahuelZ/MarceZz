using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINALZABALETTAMARCELO
{
    public partial class ModificarEmpleado : Form
    {
        private string dniOriginal;

        public ModificarEmpleado(string nombreCompleto, string dni, int edad, bool casado, double salario)
        {
            InitializeComponent();
            CenterToScreen();


            dniOriginal = dni;

            
            txtNombreCompleto.Text = nombreCompleto;
            txtDNI.Text = dni;
            txtEdad.Text = edad.ToString();
            comboCasado.SelectedItem = casado ? "Si" : "No";
            txtSalario.Text = salario.ToString();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            
            string nombreCompleto = txtNombreCompleto.Text;
            string dni = txtDNI.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            bool casado = comboCasado.SelectedItem.ToString() == "Si";
            double salario = Convert.ToDouble(txtSalario.Text);

           
            EmpleadoConexion conexion = new EmpleadoConexion();
            conexion.ModificarEmpleado(dniOriginal, nombreCompleto, dni, edad, casado, salario);

            MessageBox.Show("La Modificación ha sido exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DialogResult = DialogResult.OK; 
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
namespace ZabalettaMarcelotp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Aventura(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void botonagregar_Click(object sender, EventArgs e)
        {

            string libro;
            libro = nombrelibro.Text;

            string autor;
            autor = nombreautor.Text;

            string genero;
            genero = listagenero.Text;

            string paginas;
            paginas = cantidadpaginas.Text;

            string internacional;
            internacional = checkBoxInternacional.Checked ? "Internacional" : "Nacional";

            string precio;
            precio = preciolibro.Text;


            listadelibros.Items.Add(libro + " - " + autor + " - " + genero + " - " + paginas + " - " + internacional + " - " + precio);




        }

        private void botoncancelar_Click(object sender, EventArgs e)
        {
            nombrelibro.Text = string.Empty;
            nombreautor.Text = string.Empty;
            listagenero.SelectedIndex = -1; 
            cantidadpaginas.Text = string.Empty;
            checkBoxInternacional.Checked = false;
            preciolibro.Text = string.Empty;
        }
    }
}
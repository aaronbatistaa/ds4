namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculadora cal = new Calculadora(textBox1.Text, textBox2.Text);
            textBox3.Text = cal.calcularDistancia();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult eleccion;
            eleccion = MessageBox.Show("¿Seguro desea cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

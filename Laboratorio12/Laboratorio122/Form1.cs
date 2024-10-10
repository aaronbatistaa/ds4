namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            CalculadoraProm cal = new CalculadoraProm(inputNota1.Text,inputNota2.Text,inputNota3.Text);
            textBox4.Text = cal.calcularProm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputNota1.Text = string.Empty;
            inputNota2.Text = string.Empty;
            inputNota3.Text = string.Empty;
            textBox4.Text = string.Empty;
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
    }
}

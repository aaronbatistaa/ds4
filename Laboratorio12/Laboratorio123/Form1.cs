namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSemi_Click(object sender, EventArgs e)
        {
            CalculadoraSemi calculadoraSemi = new CalculadoraSemi(inputA.Text, inputB.Text, inputC.Text);
            textResultSem.Text = calculadoraSemi.Calcular();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            CalculadoraArea calculadoraArea = new CalculadoraArea(inputA.Text, inputB.Text, inputC.Text);
            textResultArea.Text = calculadoraArea.Calcular();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputA.Text = string.Empty;
            inputB.Text = string.Empty;
            inputC.Text = string.Empty;
            textResultSem.Text = string.Empty;
            textResultArea.Text = string.Empty;
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

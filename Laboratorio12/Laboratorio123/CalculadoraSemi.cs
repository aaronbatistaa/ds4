namespace Laboratorio123
{
    internal class CalculadoraSemi : CalculadoraTriangulo
    {
        public CalculadoraSemi(string lA, string lB, string lC)
            : base(lA, lB, lC)
        {
        }
        public override string Calcular()
        {
            if (!ladoA.HasValue || !ladoB.HasValue || !ladoC.HasValue)
                return string.Empty;

            if (!TrianguloExiste())
            {
                MessageBox.Show("El triángulo no existe con los lados ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            return semiperimetro.Value.ToString("F3");
        }
    }
}


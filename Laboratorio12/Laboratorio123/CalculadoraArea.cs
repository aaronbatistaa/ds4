namespace Laboratorio123
{
    internal class CalculadoraArea : CalculadoraTriangulo
    {
        public CalculadoraArea(string lA, string lB, string lC)  //recibe las string de los textbox
            : base(lA, lB, lC)  //envia las strings al constructor base de la clase calculadoratriangulo para que sean inicializadas y validadas según todo las validaciones del constructor de la clase base
        {
        }

        public override string Calcular()   //sobreescritura del método para que haga lo correspondiente a la clase
        {
            if (!ladoA.HasValue || !ladoB.HasValue || !ladoC.HasValue)
                return string.Empty;

            if (!TrianguloExiste())
            {
                MessageBox.Show("El triángulo no existe con los lados ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            double area = Math.Sqrt(semiperimetro.Value * (semiperimetro.Value - ladoA.Value) * (semiperimetro.Value - ladoB.Value) * (semiperimetro.Value - ladoC.Value));

            return area.ToString("F3");
        }
    }
}


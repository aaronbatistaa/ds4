namespace Laboratorio122
{
    internal class CalculadoraProm
    {
        private double? nota1;  //Utilizamos double? (nullable double) para las notas, y verificamos si las notas tienen valores válidos con HasValue antes de proceder con el cálculo.
        private double? nota2;
        private double? nota3;

        public CalculadoraProm(string n1, string n2, string n3)
        {
            List<int> notasFaltantes = new List<int>();

            if (string.IsNullOrEmpty(n1))
                notasFaltantes.Add(1);

            if (string.IsNullOrEmpty(n2))
                notasFaltantes.Add(2);

            if (string.IsNullOrEmpty(n3))
                notasFaltantes.Add(3);

            if (notasFaltantes.Count > 0)
            {
                string mensaje = "Falta ingresar la(s) nota(s): " + string.Join(", ", notasFaltantes);
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2) && !string.IsNullOrEmpty(n3))
                    {
                        if (Double.Parse(n1) < 0 || Double.Parse(n2) < 0 || Double.Parse(n3) < 0)
                        {
                            MessageBox.Show("La nota no puede ser negativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            nota1 = Double.Parse(n1);
                            nota2 = Double.Parse(n2);
                            nota3 = Double.Parse(n3);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string calcularProm()
        {
            // Solo calcula el promedio si las notas han sido asignadas correctamente
            if (nota1.HasValue && nota2.HasValue && nota3.HasValue)
            {
                return ((nota1.Value + nota2.Value + nota3.Value) / 3).ToString("F3");
            }
            else
            {
                return string.Empty; 
            }
        }
        //public string calcularProm() => ((nota1 + nota2 + nota3) / 3).ToString(); //expresión de cuerpo de miembro (expresión lambda) //pero me devuelve 0 cuando las notas están vacías
    }
}

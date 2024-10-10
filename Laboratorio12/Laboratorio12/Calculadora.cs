
using System.Drawing.Imaging;

namespace Laboratorio12
{
    internal class Calculadora
    {
        public double velocidad;
        public double tiempo;
        public double resultado;
        public Calculadora(string vel, string temp)
        {
            try
            {
                if (!string.IsNullOrEmpty(vel) && !string.IsNullOrEmpty(temp))
                {
                    if (Double.Parse(vel) <= 0)
                    {
                        MessageBox.Show("La velocidad no puede ser igual o menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else if (Double.Parse(temp) <= 0)
                    {
                        MessageBox.Show("El tiempo no puede ser igual o menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        velocidad = Double.Parse(vel);
                        tiempo = Double.Parse(temp);
                    }
                }
                else if (string.IsNullOrEmpty(vel) && !string.IsNullOrEmpty(temp))
                {
                    MessageBox.Show("Ingrese la velocidad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(temp) && !string.IsNullOrEmpty(vel))
                {
                    MessageBox.Show("Ingrese el tiempo empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ingrese la velocidad y el tiempo empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string calcularDistancia()
        {
            resultado = velocidad * tiempo;
            if (resultado != 0)
            {
               return resultado.ToString("F4");
            } else
            {
                return string.Empty;
            }
        }
    }
}

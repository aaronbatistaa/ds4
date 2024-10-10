using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio123
{
    internal abstract class CalculadoraTriangulo
    {
        protected double? ladoA; //se le pone ? para el HasValue y Value o sea para la comparación lógica de si contiene o no NUll o que esté vacío
        protected double? ladoB; //protected para que no sea accesible
        protected double? ladoC;
        protected double? semiperimetro;  //para almacenar el semiperímetro

        public CalculadoraTriangulo(string lA, string lB, string lC)     //constructor
        {
            List<int> ladosFaltantes = new List<int>();    //lista para comprobar lados faltantes

            if (string.IsNullOrEmpty(lA))
                ladosFaltantes.Add(1);

            if (string.IsNullOrEmpty(lB))
                ladosFaltantes.Add(2);

            if (string.IsNullOrEmpty(lC))
                ladosFaltantes.Add(3);

            if (ladosFaltantes.Count > 0)
            {
                string mensaje = "Falta ingresar el/los lado(s): " + string.Join(", ", ladosFaltantes);
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ladoA = double.Parse(lA);    //asignación de valores
                    ladoB = double.Parse(lB);
                    ladoC = double.Parse(lC);

                    if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
                    {
                        MessageBox.Show("Los lados de un triángulo deben ser positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ladoA = ladoB = ladoC = null;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (ladoA.HasValue && ladoB.HasValue && ladoC.HasValue)
            {
                CalcularSemiperimetro();
            }

        }

        protected bool TrianguloExiste()    //verifica según el Teorema de desigualdad de triángulos que el mismo exista, para que el área no salga como NaN y avise al usuario
        {
            if (ladoA.HasValue && ladoB.HasValue && ladoC.HasValue)
            {
                double a = ladoA.Value;    //crea y asigna los valores de los lados para la comprobación
                double b = ladoB.Value;
                double c = ladoC.Value;

                return (a + b > c) && (a + c > b) && (b + c > a);
            }
            else
            {
                return false;
            }
        }
        protected void CalcularSemiperimetro() //para evitar tener la misma operación del semiperímetro en ambas clases, se realiza en esta base
        {
            semiperimetro = (ladoA.Value + ladoB.Value + ladoC.Value) / 2;
        }

        public abstract string Calcular();   //método para calcular el área y el semiperímetro que se utilizará para ambas clases mediante override
    }
}


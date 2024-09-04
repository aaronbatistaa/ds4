using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System = System.Math;

namespace CalculoInicial
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de diferencia de cuadrados");
            CalculosMatematicos calculosMatematicos = new CalculosMatematicos();
            Console.Write("Ingrese el número A: ");
            calculosMatematicos.num1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el número B: ");
            calculosMatematicos.num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("El resultado la diferencia de cuadrados de {0} y {1} es {2}", calculosMatematicos.num1, calculosMatematicos.num2, calculosMatematicos.CalculoDif());


            Console.WriteLine("¡Muchas Gracias por su Cálculo!");
        }
    }

    public class CalculosMatematicos
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double radio { get; set; }
        public double ladoA { get; set; }
        public double ladoB { get; set; }

        public double CalculoDif()
        {
            return (num1 + num2) * (num1 - num2);
        }

        public double calculoArea()
        {
            return Math.Round(Math.PI * Math.Pow(radio, 2),2);
        }
        
        public double calculoPerimetro()
        {
            return 2 * (ladoA + ladoB);
        }

    }
}

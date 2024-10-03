using System;
using Parcial_I;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int N = solicitarInfo();
            Randomizador matriz = new Randomizador(N);
            matriz.GenerarMatriz();
            matriz.MostrarMatriz();

            if (N == 3)
            {
                int suma = matriz.SumarColumna(1);
                Console.WriteLine("\nSuma de los valores de la columna central: " + suma);
            }
            else
            {
                int sumaSegunda = matriz.SumarColumna(1);
                int sumaPenultima = matriz.SumarColumna(N - 2);
                Console.WriteLine("\nSuma de los valores de la segunda columna: " + sumaSegunda);
                Console.WriteLine("Suma de los valores de la penúltima columna: " + sumaPenultima);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static int solicitarInfo()
    {
        Console.Write("Ingrese un número impar para determinar el tamaño de la matriz: ");
        int N = 0;
        while (true)
        {
            try
            {
                N = int.Parse(Console.ReadLine());
                if (N % 2 == 0 || N <= 0)
                {
                    throw new Exception("El número debe ser impar y positivo.");
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return N;
    }
}

using CalculoInicial;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Perímetro de un Rectángulo");
        CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

        Console.Write("Ingrese el lado A del rectángulo en centímetros: ");
        calculosMatematicos.ladoA = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el lado B del rectángulo en centímetros: ");
        calculosMatematicos.ladoB = double.Parse(Console.ReadLine());

        Console.WriteLine("El perímetro del rectángulo cuyo lado A es {0} cm y cuyo lado B es {1} cm, es de {2} cm", calculosMatematicos.ladoA, calculosMatematicos.ladoB, calculosMatematicos.calculoPerimetro());
        Console.WriteLine("¡Muchas Gracias por su Cálculo!");

    }
}
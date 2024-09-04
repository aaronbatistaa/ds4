using CalculoInicial;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Área de un Círculo");
        CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

        Console.Write("Ingrese el radio del Círculo en centímetros: ");
        calculosMatematicos.radio = double.Parse(Console.ReadLine());
            
        Console.WriteLine("El área del círculo cuyo radio es {0} cm, es de {1} cm²", calculosMatematicos.radio, calculosMatematicos.calculoArea());

        Console.WriteLine("¡Muchas Gracias por su Cálculo!");
    }
}
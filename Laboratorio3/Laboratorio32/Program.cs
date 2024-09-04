using CalculoInicial;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Área de un Círculo");
        CalculosMatematicos calculosMatematicos = new CalculosMatematicos();
        Console.Write("Ingrese el radio del Círculo: ");
        calculosMatematicos.radio = double.Parse(Console.ReadLine());
            
        Console.WriteLine("El área del círculo cuyo radio es {0}, es de {1}", calculosMatematicos.radio, calculosMatematicos.calculoArea());


        Console.WriteLine("¡Muchas Gracias por su Cálculo!");
    }
}
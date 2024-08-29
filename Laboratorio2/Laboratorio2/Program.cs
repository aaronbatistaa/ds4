namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int nombreVariable = 1000;
            int valor1 = 28; //declaramos valor1 con un valor de 28
            int valor2 = valor1; //Asignamos el valor de valor1 a valor2
            valor2 = 30;
            //Impriendo en consola variables
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            //Mas tipos de datos de variables
            char caracter = 'A'; //Variable almacenando el carácter de A.
            string cadena = "Cadena de caracteres"; //Variable almacenando una cadena de caracteres
            bool condicion = true; //Variable almacenando una estado de condición verdadero

            Client client = new Client();
            //Ejemplo utilizando las variables de instancia de Clase.
            client.FirstName = "Su_Nombre";
            client.LastName = "Su_Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

            //Asignando valor a variable estatica.
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);

            MyClass object1 = new MyClass(); //Creando una nueva instancia
            object1.Nombre = "Yeison";
            object1.Edad = 28;
            MyClass object2 = object1; // Asignando un variable a otra

            object2.Nombre = "Jose"; //Este cambio en la propiedad afecta tanto a objet1 como object2

            //Al imprimir en consola vemos que ambas referencias imprimen el mismo valor Jose.
            Console.Write(object2.Nombre);
            Console.WriteLine(object1.Nombre);
        }
    }

    public class Client
    {
        //Declarando variables de instancia en clase
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            //Utilizando variables de instancia dentro de metodos de la clase.
            return FirstName + " " + LastName;
        }
    }

    public class MyClass
    {
        //declarando variable estática
        public static int Valor;

        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public class Operacion
    {
        //Definición de método que suma dos números e imprime el resultado
        public void Sumar(int valor1, int valor2)
        {
            int variableLocal = valor1 + valor2; //declarando variable local variableLocal
            Console.WriteLine(variableLocal); //Esto imprime el resultado de la suma.
        }
    }
}
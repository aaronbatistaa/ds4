class Program
{

    static void Main(string[] args)
    {
        /*
        Declaración erronea
        int valores[];

        Declaración valida*/
        int[] valores;  //valores sin inicializar


        valores = new int[100];     //100 elementos
        valores = new int[20];  //ahora contiene 20 elementos


        //Arreglos unidimensionales o de dimensión simple
        int[] valores1;      //sin inicializar
        int[] valores2 = new int[50];

        //Arreglos multidimensionales
        int[,] valores3;    //sin inicializar
        int[,] valores4 = new int[3, 7];
        int[,,] valores5 = new int[3, 4, 2];    //Arreglo de tres dimensiones


        //Arreglo de arreglos
        int[][] matriz;     //sin inicializar

        //Los arreglos de arreglos se inicializan de manera diferente
        int[][] matriz2 = new int[3][];
        for (int i = 0; i < matriz2.Length; i++)
        {
            matriz2[i] = new int[4];
        }


        // M A T R I C E S

        //Declaración e Instanciación

        //Unidimensionales
        int[] mumbers;
        int[] numbers = new int[5];

        //Multidimensionales
        //string[,] names;
        string[,] names = new string[5, 4];

        //Matrices de Matrices (escalonadas)
        //byte[][] scores;
        byte[][] scores = new byte[5][];
        for (int x = 0; x < scores.Length; x++)
        {
            scores[x] = new byte[4];
        }


        //Matriz Rectangular de Tres Dimensiones
        int[,,] buttons = new int[4, 5, 3];

        //Declaración de una matriz unidimensional que continee matrices tridimensionales de matrices bidimensionales de tipo int
        int[][,,][] numbers1;


        // C I C L O   F O R   E A C H
        int[]
            numeros = { 1, 2, 3, 4, 5 };
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
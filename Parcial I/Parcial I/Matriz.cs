using System;

abstract class Matriz
{
    protected int N;
    protected int[,] matrizI;

    public Matriz(int n)
    {
        N = n;
        matrizI = new int[N, N];
    }

    public abstract void GenerarMatriz();
    public virtual void MostrarMatriz()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrizI[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public int SumarColumna(int col)
    {
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += matrizI[i, col];
        }
        return sum;
    }
}
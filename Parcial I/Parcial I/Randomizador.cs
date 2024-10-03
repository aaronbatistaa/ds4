using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_I
{
    class Randomizador : Matriz
    {
        private Random rand;

        public Randomizador(int n) : base(n)
        {
            rand = new Random();
        }

        public override void GenerarMatriz()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (N == 3 && j == N / 2)
                    {
                        matrizI[i, j] = rand.Next(101, 201);
                    }
                    else if (N != 3 && (j == 1 || j == N - 2))
                    {
                        matrizI[i, j] = rand.Next(101, 201);
                    }
                    else
                    {
                        matrizI[i, j] = 0;
                    }
                }
            }
        }

        public override void MostrarMatriz()
        {
            Console.WriteLine("Matriz Generada:");
            base.MostrarMatriz();
        }
    }

}

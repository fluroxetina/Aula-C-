using System;

namespace J
{
    class AtividadeFuc
    {
        public class M
        {
            public int[,] viraMatriz(int[,] a)
            {

                int[,] trans = new int[3, 3];

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        trans[j, i] = a[i, j];
                    }
                }
                return trans;
            }
        }

        static void Main(string[] args)
        {
            M i = new M();
            int[,] fa = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] MTir = i.viraMatriz(fa);

            for (int x = 0; x < MTir.GetLength(0); x++)
            {
                for (int y = 0; y < MTir.GetLength(1); y++)
                {
                    Console.Write(MTir[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}





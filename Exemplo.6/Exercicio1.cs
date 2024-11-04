using System;

namespace Teste
{
    class Teste
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3]{ 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } };

            int[,] trans = new int[3, 3];

            // Transpor a matriz
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    trans[j, i] = mat[i, j];
                }
            }

            // Exibir a matriz transposta
            for (int i = 0; i < trans.GetLength(0); i++)
            {
                for (int j = 0; j < trans.GetLength(1); j++)
                {
                    Console.Write(trans[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



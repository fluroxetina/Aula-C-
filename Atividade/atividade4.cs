using System;

namespace Atividade3
{
    class Atividade3
    {
        static void Main(string[] args)
        {
            
            int[,] mat = new int[3, 3] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            int soma = 0;
            int soma2 = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j) 
                    {
                        soma += mat[i, j];
                    }
                    if (i + j == mat.GetLength(0) - 1) 
                    {
                        System.Console.WriteLine(mat[i, j]);
                        soma2 += mat[i, j];
                    }
                }
            }

            Console.WriteLine($"A soma das diagonais é: {soma} e {soma2}");
        }
    }
}

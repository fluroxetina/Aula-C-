namespace Exemplo_7
{   
    public class Mudificador
    {
        public int soma (int[,] a )
        {
            int soma = 0;
            int soma2 = 0;
            int[] valores = new int[0];

            for (int i = 0 ; i < a.GetLength(0); i++)
            {
                for (int j = 0 ; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        soma += a[i, j];
                    }

                    if (i + j == a.GetLength(0)-1)
                    {
                        soma2 += a[i, j]
                    }
                }
            }

            for(int i = 0; i < valores.Length; i++){
                valores[i] = soma;
                valores[i] = soma2;
                System.Console.WriteLine(valores[i]);
            }
           


        }
        static void Main()
        {     
            int[,] m= new int[4, 4]{
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}};
        }
    }
}


//   int[,] mat = new int[3, 3] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
//             int soma = 0;
//             int soma2 = 0;

//             for (int i = 0; i < mat.GetLength(0); i++)
//             {
//                 for (int j = 0; j < mat.GetLength(1); j++)
//                 {
//                     if (i == j) 
//                     {
//                         soma += mat[i, j];
//                     }
//                     if (i + j == mat.GetLength(0) - 1) 
//                     {
//                         System.Console.WriteLine(mat[i, j]);
//                         soma2 += mat[i, j];
//                     }
//                 }
//             }

//             Console.WriteLine($"A soma das diagonais é: {soma} e {soma2}");
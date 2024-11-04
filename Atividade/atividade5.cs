using System;

namespace Atividade3
{
    class Atividade3
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3]{ 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } };

            int[,] trans = new int[3, 3];

            int[,] trans2 = new int[3, 3];
           
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    trans[j, i] = mat[i, j];
                }
            }



            for(int j = 0 ; j < mat.GetLength(0) j++){
                
                for(int x = 0 ; x < mat.GetLength(1); x++ ){

                    trans2[j, i] = trans[i, trans.GetLength(0) - j - 1];
                }
            }

            foreach (int item in trans2)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}

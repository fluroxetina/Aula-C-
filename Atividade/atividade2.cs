using System;

namespace Atividade2
{
    class Atividade2
    {
        static void Main(string[] args)
        {   
            int soma = 0;
              
            int[,] mat = new int[4, 4] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}};
                
            for(int i = 0 ; i < mat.GetLength(0) ; i++){
                
                soma = 0 ;
                for(int j = 0 ; j < mat.GetLength(1) ; j++){
                    
                     soma += mat[i, j];
           
                }
                
            Console.WriteLine(soma);
            
            }              
        }
    }
}
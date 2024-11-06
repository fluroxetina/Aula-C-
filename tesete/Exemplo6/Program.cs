using System;

namespace Exemplo6
{
    class Exemplo6
    {
        static void Main(string[] args)
        {
            //Formar de declarar um matriz 

            int[,] mat = new int[2, 2]; // Primeiro valor indica as linhas e o segundo valor indica as colunas

            int[,] mat2 = new int[2, 2] {
                {1,2},
                {3,4}
            }; // Forma mais simples de declarar uma matriz

            for(int i = 0; i < mat2.GetLength(0); i++){

                for(int j = 0; j < mat2.GetLength(1); j++){

                    System.Console.WriteLine(mat2[i,j]);
                }
            }


            //somando os elementos de uma matriz

            int[,] mat3 = new int[3, 3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int[,] mat4 = new int[3, 3]{
                {9,8,7},
                {6,5,4},    
                {3,2,1}
            };
            
            int[,] mat5 = new int[3, 3];


            for(int i = 0; i < mat3.GetLength(0); i++){ 
                for(int j = 0; j < mat3.GetLength(1); j++){

                    mat5[i,j] = mat3[i,j] + mat4[i,j];
                }
                
            }

            int soma = 0;



            System.Console.WriteLine(mat2[0,0]);
        }
    }
}   

descobriando e somando o menor e maior numero de uma matriz
using System;

class HelloWorld {
  static void Main() {
   

            int[] numeros = new int[10];
            
            
            for (int i = 0; i < 10;  i++){
            
                System.Console.WriteLine("Escreve");
                int num = int.Parse(Console.ReadLine());
            
                numeros[i] = num;
                
            }
            
            for(int j = 0 ; j < 10 ; j++){
                
                System.Console.WriteLine(numeros[j]);
            
            }
            
            for(int x = 9; x >= 0; x--){
                System.Console.WriteLine(numeros[x]);
            }
            
            Random r = new Random();
            
            int[,] mat = new int[4, 4] {
                {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                {r.Next(10),r.Next(10),r.Next(10),r.Next(10)}};
            
                
            int maior = 0;
            int menor = int.MaxValue;
            
            for(int i = 0; i < 4 ; i++){
                for(int j = 0 ; j < 4; j ++){
                    
                    
                    if( mat[i, j] >= maior){
                        
                        maior = mat[i, j];
                       
                        
                    }
              
                    if( mat[i, j] <= menor){
                        
                        menor = mat[i, j];
                       
                        
                    }
              
                   
                }
            }
            
        Console.WriteLine($"{maior} + {menor} = {maior + menor}");
            //Somando os numeros que estão na diagonal de uma matriz
                Random r = new Random();
                
                int[,] mat = new int[4, 4] {
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)}};
                    
                    

                int[,] mat = new int [2,2]{
                    {1, 2},
                    {3, 4}
                };

                int sum = 0;
                
                for(int i = 0; i < 2; i ++){
                    
                    sum += mat[i, i];
                    
                }
                
                Console.WriteLine(sum);
                
                // Somando 2 matrizes
                Random r = new Random();
                
                
                int[,] mat = new int[4, 4] {
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)}};
                    
                int[,] mat2 = new int[4, 4] {
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                    {r.Next(10),r.Next(10),r.Next(10),r.Next(10)}};
                    
                    
                int[,] mat3 = new int[4, 4];
                
                for(int i = 0 ; i < 4; i++){
                    for(int j = 0; j < 4 ; j++){
                        
                        mat3[i, j] = mat[i, j] + mat2[i, j];
                        
                        
                        Console.WriteLine(mat3[i, j]);
                    }
                    
                }
                //Miltiplicando 2 matrizes
                Random r = new Random();
                
                 int[,] mat = new int[4, 4] {
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)}};
                    
                 int[,] mat2 = new int[4, 4] {
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
                     {r.Next(10),r.Next(10),r.Next(10),r.Next(10)}};
                    
                    
                int[,] mat3 = new int[4, 4];
                
                for(int i = 0 ; i < 4; i++){
                    for(int j = 0; j < 4 ; j++){
                        
                        mat3[i, j] = mat[i, j] * mat2[i, j];
                        
                        
                        Console.WriteLine(mat3[i, j]);
                    }
                    
                }
                
                
                
                
                
                
  }

}


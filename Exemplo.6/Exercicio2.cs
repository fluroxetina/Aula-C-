using System;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            //Matrizes tridimensionais
            // 1 Linha 
            // 2 Colunas
            // 3 Profundidade

            int[,,] mat3D = new int[2, 2, 2] {
                {
                    {1, 2},
                    {3, 4}
                },
                {
                    {5, 6},
                    {7, 8}
                }
            };
            
            for (int i = 0; i < mat3D.GetLength(0); i++){ // linhas
                for (int j = 0; j < mat3D.GetLength(1); j++){ // colunas
                    for (int k = 0; k < mat3D.GetLength(2); k++){ // profundidade
                        Console.WriteLine($"[{i}, {j}, {k}] = {mat3D[i, j, k]}");
                    }
                }
            }
        //acassar matriz
        mat3D[1, 1, 1] = 1000;

        System.Console.WriteLine(mat3D[1, 1, 1]);

            
        }
    }
}

using System;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            //Matrizes tridimensionais
            // 1 Linha 
            // 2 Colunas
            // 3 Profundidade

            int[,,] mat3D = new int[2, 2, 2] {
                {
                    {1, 2},
                    {3, 4}
                },
                {
                    {5, 6},
                    {7, 8}
                }
            };
            
            int soma = 0 ;
            
            // for (int i = 0; i < mat3D.GetLength(0); i++){ // linhas
            
            //     for (int j = 0; j < mat3D.GetLength(1); j++){ // colunas
                
            //         for (int k = 0; k < mat3D.GetLength(2); k++){ // profundidade
                        
            //              soma += mat3D[i, j, k];
                        
                        
                        
            //         }
            //     }
            // }
            // Console.WriteLine(soma);
        
            foreach(int i in mat3D)
            {
                Console.WriteLine(i);
                
                soma += i;
                
            }
            
            Console.WriteLine(soma);
        }
    }
}
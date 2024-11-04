// using System;

// namespace Atividade2
// {
//     class Atividade2
//     {
//         static void Main(string[] args)
//         {   
//             int soma = 0;
            
//             Random r = new Random();
                
//             int[,] mat = new int[4, 4] {
//                 {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
//                 {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
//                 {r.Next(10),r.Next(10),r.Next(10),r.Next(10)},
//                 {r.Next(10),r.Next(10),r.Next(10),r.Next(10)}};

                
//             for(int i = 0 ; i < mat.GetLength(0) ; i++){
                
//                 soma = 0 ;
//                 for(int j = 0 ; j < mat.GetLength(1) ; j++){
                    
//                      soma += mat[i, j];
           
//                 }
                
//             Console.WriteLine(soma);
            
//             }
            
            
//         }
    
//     }
// }
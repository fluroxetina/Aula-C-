// namespace Exemplo_7
// {   
//     class AtividadeFuc
//     {
//         public delegate void Operacao(int[,] a );

//         static void SomaLinha (int[,] a){
//             int soma = 0;

//             for (int i = 0 ; i < a .GetLength(0); i++)
//             {
//                 soma = 0 ;
//                 for(int j = 0 ; j < a.GetLength(1) ; j++){
                    
//                      soma += a[i, j];
           
//                 }

//                 System.Console.WriteLine(soma);
//             }


//         }
//         static SomarLinhaMatriz()
//         {
//             Operacao op = SomaLinha;


//             int[,] mat = { 
//                 { 1, 2, 3 }, 
//                 { 4, 5, 6 }, 
//                 { 7, 8, 9 } };

//             op(mat);

//         }
//     }
// }


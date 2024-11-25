// using System;

// namespace Exemplo._13
// {
//     public class Lista
//     {
//         static int[] vetor = new int[10];
        
//         static void Inserir(int valor)
//         {
//             for(int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] == 0)
//                 {
//                     vetor[i] = valor;
//                     break;

//                 } 
//             }
//         }

//         static void Remover(int valor) 
//         {
//             for(int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] == valor)
//                 {
//                     vetor[i] = 0;
//                     break;
//                 }
//             }
//         }

//         static void Listas()
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 Console.WriteLine(vetor[i]);
//             }

//         }

//         static void ListarINverso()
//         {
//             for(int i = vetor.Length - 1; i >= 0; i--)
//             {
//                 if (vetor[i] != 0)
//                 {
//                     System.Console.WriteLine(vetor[i]);
//                 }
//             }
//         }

//         static void Main(string[] args)
//         {
//             Inserir(60);
//             Inserir(20);
//             Inserir(40);
//             Inserir(70);
//             Inserir(10);
//             Inserir(50);
//             Inserir(30);
//             Inserir(90);
//             Lista();
//         }
//     }
// }
// using System;

// namespace Exemplo_13
// {
//     public class Pilha
//     {
//         static int[] pilha = new int[10];

//          static int topo = 0;

//         public static void Empilhar(int valor) 
//         {
//             if (topo < pilha.Length)
//             {
//                 pilha[topo] = valor;
//                 topo ++;
//             }
//             else{
//                 System.Console.WriteLine("Pilha cheia");
//             }
//         }

//         public static void Desempilhar(){
//             if (topo > 0)
//             {
//                 topo --;
//                 pilha[topo] = 0;
//             }
//             else
//             {
//                 System.Console.WriteLine("Pilha vazia");
//             }
//         }

//         public static void Imprimir(){
//             for (int i = 0; i < topo; i++)
//             {
//                 System.Console.WriteLine(pilha[i]);
//             }
//         }

//         static void Main(string[] args)
//         {
//             Empilhar(1);
//             Empilhar(2);
//             Empilhar(3);
//             Empilhar(4);
//             Empilhar(5);
//             Empilhar(6);
//             Empilhar(7);
//             Empilhar(8);
//             Empilhar(9);
//             Empilhar(10);
//             System.Console.WriteLine("\nImprimindo a pilha");
//             Imprimir();
//             System.Console.WriteLine("\nDesempilhando da pilha");
//             Desempilhar();
//         }
//     }
// }
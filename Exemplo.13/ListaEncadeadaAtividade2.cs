// // Exercício 2: Verificar se um valor está na lista
// // o Crie uma função que percorra a lista encadeada e verifique se um valor
// // específico existe nela.
// // o Exemplo de uso:
// // Lista: 10 -> 20 -> 30
// // Contem(20) -> true
// // Contem(40) -> false



// using System;
// namespace Exemplo_13
// {
//     public class ListaEncadeada
//     {
//         class Node
//         {
//             public int Valor;

//             public Node? Proximo;
//         }

//         static Node? inicio = null;

//         static void Inserir(int valor )
//         {
//             Node novonode = new Node{ Valor = valor , Proximo = inicio};

//             if(inicio == null)
//             {
//                 inicio = novonode;
//             }
//             else
//             {
//                 Node atual = inicio;

//                 while(atual.Proximo != null) 
//                 {
//                     atual = atual.Proximo;
//                 }
//                 atual.Proximo = novonode;

//             }
//         }

//         static void Remover(int valor)
//         {
//             if(inicio == null)return;
            
//             if (inicio.Valor == valor)
//             {
//                 inicio = inicio.Proximo;
//                 return;

//             }
//         }

//         static void Imprimir()
//         {
//             Node? atual = inicio;
//             System.Console.WriteLine("Valores da lista:");

//             while(atual != null)
//             {
//                 Console.WriteLine(atual.Valor);
//                 atual = atual.Proximo;
//             }
//         }

//         static bool Contem(int valor)
//         {
//             Node? atual = inicio; 

//             bool contem = false; 

//             while(atual != null)
//             {
//                 if(atual.Valor == valor)
//                 {
//                     contem = true;
//                     break;
//                 }
//                 atual = atual.Proximo;
//             }

//             return contem;

            

           
//         }
//         static void Main(string[] args)
//         {
//             Inserir(10);
//             Imprimir();

//             Console.WriteLine(Contem(10));
//         }
//     }
// }
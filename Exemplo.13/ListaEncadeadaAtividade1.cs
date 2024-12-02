// // . Exercício 1: Inserir em uma posição específica
// // o Escreva uma função para inserir um valor em uma posição específica na
// // lista encadeada. Se a posição for inválida, exiba uma mensagem de erro.
// // o Exemplo de uso:
// // Lista: 10 -> 20 -> 30
// // Inserir(25, 2)
// // Resultado: 10 -> 25 -> 20 -> 30



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


//         static void Inserir(int valor, int posicao)
//         {
//             Node novonode = new Node{ Valor = valor , Proximo = inicio};
//             int cont = 0; 
//             if(inicio == null)
//             {
//                 inicio = novonode;
//             }
//             else
//             {
//                 Node atual = inicio;

//                 while(atual.Proximo != null && cont < posicao - 1 ) 
//                 {
//                     atual = atual.Proximo;
//                     cont ++;
//                 }
//                 novonode.Proximo = atual.Proximo; 
//                 atual.Proximo = novonode;


//             }
//         }

//         static void Remover(int valor) 
//         {
            
//             if(inicio == null)
//             {
//                 return;
//             }

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

   
//         static void Main(string[] args)
//         {

//             Inserir(10, 3);
//             Inserir(20, 1);
//             Inserir(30, 2);
//             Inserir(40, 1);
          

//             Imprimir();

//         }
//     }
// }
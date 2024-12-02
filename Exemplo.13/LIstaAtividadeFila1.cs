// using System;

// namespace Exemplo_13
// {
//     public class FilaEncadeada
//     {
//         class Node
//         {
//             public int Valor;
//             public Node? Proximo;
//         }

//         private Node? inicio = null;
//         private Node? fim = null;

     
//         public void Enfileirar(int valor)
//         {
//             Node novoNode = new Node { Valor = valor, Proximo = null };

//             if (inicio == null)
//             {
//                 inicio = novoNode;
//                 fim = novoNode;
//             }
//             else
//             {
//                 fim!.Proximo = novoNode;
//                 fim = novoNode;
//             }
//         }

   
//         public int? Desenfileirar()
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("Fila vazia");
//                 return null;
//             }

//             int valor = inicio.Valor;
//             inicio = inicio.Proximo;

//             if (inicio == null) fim = null; 

//             return valor;
//         }

 
//         public void Listar()
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("Fila vazia");
//                 return;
//             }

//             Node? atual = inicio;
//             while (atual != null)
//             {
//                 Console.Write(atual.Valor + " - ");
//                 atual = atual.Proximo;
//             }
//             System.Console.WriteLine("\n");
//         }

//         public void InserirFila(FilaEncadeada outraFila)
//         {
//             Node? atual = outraFila.inicio;

//             while (atual != null)
//             {
//                 Enfileirar(atual.Valor);
//                 atual = atual.Proximo;
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             FilaEncadeada fila1 = new FilaEncadeada();
//             FilaEncadeada fila2 = new FilaEncadeada();

         
//             fila1.Enfileirar(10);
//             fila1.Enfileirar(20);

         
//             fila2.Enfileirar(30);
//             fila2.Enfileirar(40);

//             Console.WriteLine("Fila 1:");
//             fila1.Listar();

//             Console.WriteLine("Fila 2:");
//             fila2.Listar();

           
//             fila1.InserirFila(fila2);

//             Console.WriteLine("Fila 1 após inserir elementos da Fila 2:");
//             fila1.Listar();
//         }
//     }
// }

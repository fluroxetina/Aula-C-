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
//             if(inicio = null)return;
            
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
            
//         }
//     }
// }
// // using System;

// // namespace Exemplo12ListPilhFilaENCADEADA
// // {
// //     class Lista
// //     {
// //         // Estrutura de um nó (Node) para armazenar valores e apontar para o próximo nó
// //         class Node
// //         {
// //             public int Valor;      // Valor armazenado no nó
// //             public Node? Proximo;  // Referência para o próximo nó na lista encadeada
// //         }

// //         // Variável para armazenar o início da lista encadeada
// //         private Node? inicio = null;

// //         // Função para inserir um valor no final da lista
// //         public void Inserir(int valor)
// //         {
// //             Node novoNode = new Node { Valor = valor, Proximo = null };

// //             if (inicio == null)
// //             {
// //                 inicio = novoNode;
// //             }
// //             else
// //             {
// //                 Node atual = inicio;
// //                 while (atual.Proximo != null)
// //                 {
// //                     atual = atual.Proximo;
// //                 }
// //                 atual.Proximo = novoNode;
// //             }
// //         }

// //         // Função para excluir um valor específico da lista
// //         public void Excluir(int valor)
// //         {
// //             if (inicio == null) return;

// //             if (inicio.Valor == valor)
// //             {
// //                 inicio = inicio.Proximo;
// //                 return;
// //             }

// //             Node atual = inicio;
// //             while (atual.Proximo != null && atual.Proximo.Valor != valor)
// //             {
// //                 atual = atual.Proximo;
// //             }

// //             if (atual.Proximo != null)
// //             {
// //                 atual.Proximo = atual.Proximo.Proximo;
// //             }
// //         }

// //         // Função para listar todos os valores da lista
// //         public void Listar()
// //         {
// //             if (inicio == null)
// //             {
// //                 Console.WriteLine("A lista está vazia.");
// //                 return;
// //             }

// //             Node? atual = inicio;
// //             Console.WriteLine("Elementos na lista:");

// //             while (atual != null)
// //             {
// //                 Console.WriteLine(atual.Valor);
// //                 atual = atual.Proximo;
// //             }
// //         }

// //         // Função principal para execução do programa
// //         static void Main()
// //         {
// //             Lista lista = new Lista();

// //             // Insere valores na lista
// //             lista.Inserir(10
            
// //             );
// //             lista.Inserir(20);
// //             lista.Inserir(30);

// //             // Lista os valores da lista
// //             lista.Listar();

// //             // Exclui o valor 20 e lista novamente para verificar a remoção
// //             Console.WriteLine("Excluir 20");
// //             lista.Excluir(20);
// //             lista.Listar();
// //         }
// //     }
// // }


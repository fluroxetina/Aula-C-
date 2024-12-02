// using System;

// namespace Exemplo_13
// {
//     public class PilhaEncadeada
//     {

//         class Node
//         {
//             public int Valor;

//             public Node? Proximo;
//         }

//         static Node? topo = null;

    
//         static void Empilhar(int valor)
//         {   

//             Node novoNode = new Node {Valor = valor, Proximo = topo};

//             topo = novoNode;


//         }

//         static void Desempilhar()
//         {
//             if (topo == null)
//             {
//                 System.Console.WriteLine("Pilha vazia");
//                 return;
//             }   
//             System.Console.WriteLine($"Desempilhar {topo.Valor}");
//             topo = topo.Proximo;
//         }


//         static void Listar()
//         {
//             if (topo == null)
//             {
//                 System.Console.WriteLine("Pilha vazia");
//                 return;
//             }   
//             Node? aux = topo;
//             while (aux != null)
//             {
//                 System.Console.WriteLine(aux.Valor);
//                 aux = aux.Proximo;
//             }
//         }

//         static void InverterPilha()
//         {
//             if (topo == null)
//             {
//                 System.Console.WriteLine("Pilha vazia");
//                 return;
//             }  

//             Node? anterior = null;
//             Node? atual = topo; 
//             Node? proximo = null;

//             System.Console.WriteLine("O topo da pilha invertida");
//             while (atual != null) 
//             {
//                 proximo = atual.Proximo;

//                 atual.Proximo = anterior;
//                 anterior = atual; 
//                 atual = proximo;
                
//             }

//             topo = anterior;
//             System.Console.WriteLine(topo.Valor);
  

//         }

        
//         static void Main(string[] args)
//         {

//             Empilhar(10);   
//             Empilhar(20);
//             Empilhar(30);
//             Empilhar(40);
//             Listar();

//             InverterPilha();
//         }
//     }
// }
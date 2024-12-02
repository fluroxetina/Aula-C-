// using System;

// namespace Exemplo_13 
// {
//     public class ListaDuplamenteEncadeada
//     {

//         class Node 
//         {
//             public int Valor;
//             public Node? Anterior;
//             public Node? Proximo; 
//         }

//         static Node Inicio = null;

//         static void Inserir(int valor1)
//         {
//             Node NovoNode = new Node {Valor = valor1, Anterior = null, Proximo = null} ; 
            

//             if(Inicio == null)
//             {
//                 Inicio = NovoNode;
//             }   
//             else
//             {
//                 Node atual = Inicio;
//                 while(atual.Proximo != null)
//                 {
//                     atual = atual.Proximo;
//                 }
//                 atual.Proximo = NovoNode; 
//                 NovoNode.Anterior = atual;
//             }
//         }


//         static void Excluir(int valor1)
//         {
          
//             if(Inicio == null)
//             {
//                 System.Console.WriteLine("Lista vazia");
//                 return;
//             }
//             // if(Inicio.Valor == valor1)
//             // {
//             //     Inicio = Inicio.Proximo; 
//             //     Inicio.Anterior = null;
//             //     return;
//             // }
//             if(Inicio.Valor == valor1) 
//             {
//                 if(Inicio.Proximo != null) 
//                 {
//                     Inicio.Proximo.Anterior = null;
//                 }
//                 Inicio = Inicio.Proximo;
//                 return;

//             }

//             Node atual = Inicio; 
//             while(atual != null && atual.Valor != valor1)
//             {
//                 atual = atual.Proximo; 
//             }

//             if(atual != null)
//             {
//                 if(atual.Anterior != null)
//                 {
//                     atual.Anterior.Proximo = atual.Proximo;
//                 }
//                 if(atual.Proximo != null) 
//                 {
             
//                     atual.Anterior.Proximo = atual.Proximo; 
//                 }
//             }
//         }

//         static void Listar()
//         {
//             Node? atual = Inicio;
//             while(atual != null)
//             {
//                 System.Console.WriteLine(atual.Valor); 
//                 atual = atual.Proximo; 
//             }
//         }
        
//         static void Main(string[] args)
//         {
//             Inserir(10);
//             Inserir(30);
//             Inserir(10);
//             Inserir(40);
//             Inserir(80);
//             Listar();
//         }
//     }
// }
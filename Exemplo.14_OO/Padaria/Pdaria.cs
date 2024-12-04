// using System;

// namespace Exemplo_14
// {
//     public class Padaria
//     {

//         public string NomeAlimento;
//         public double Preco;
//         public string Bebidas;
//         public string Doces;
        

//         public string Encomenda()
//         {
//             return "Encomenda de " + NomeAlimento + " no valor de " + Preco  ;
//         }

//         // public double CestaCompras(string nome, double preco)
//         // {
//         //     return preco;
//         // }

//         public double CestaCompras(List<(string NomeAlimento, double Preco)> itens)
//         {
//             double total = 0; 

//             foreach(var item in itens )
//             {
//                 System.Console.WriteLine($"Item: {item.NomeAlimento} Preco:{item.Preco}");
//                 total += item.Preco;
                
//             }
//             return total;
//         } 

//     }
// }
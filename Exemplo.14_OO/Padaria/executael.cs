// using System;

// namespace Exemplo_14
// {
//     public class jao
//     {
//         static void Main(string[] args)
//         {
//             Padaria padaria1 = new Padaria();

//             padaria1.NomeAlimento = "Bolo de Chocolate";
//             padaria1.Preco = 20.99;
//             padaria1.Bebidas = "Café";
//             padaria1.Doces = "Chocolate";
            
 
            

//             System.Console.WriteLine(padaria1.Encomenda());
            
//             List<(string NomeAlimento, double Preco)> ListaDeCompras = new List<(string NomeAlimento, double Preco)>
//             {
//                 ("Pão de Queijo", 10.99),
//                 ("Bolo de Chocolate", 20.99),
//                 ("Cafe", 5.99),
//                 ("Chocolate", 2.99)
//             };
//             double total = padaria1.CestaCompras(ListaDeCompras);
//             System.Console.WriteLine($"Total de cestas de compras R${total:F2}");

//         }
//     }
// }
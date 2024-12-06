// using System;

// namespace Exemplo_15OO
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             Carnes C = new Carnes("Coxão mole", 10.50, 100);
//             Ferramentas F = new Ferramentas("Chave inglesa", 5.99, 100);
//             Laticinios La = new Laticinios("Leite", 5.99, 100);
//             Limpesa L = new Limpesa("Pano", 5.99, 100);
//             Petiscos P = new Petiscos("Sorvete", 5.99, 100);

//             System.Console.WriteLine(C.Exibir());
//             System.Console.WriteLine(F.Exibir());
//             System.Console.WriteLine(La.Exibir());
//             System.Console.WriteLine(L.Exibir());
//             System.Console.WriteLine(P.Exibir());
            
//             double maiorValor = Math.Max(C.CalcularEstoque(),
//             Math.Max(L.CalcularEstoque(),
//                 Math.Max(La.CalcularEstoque(),
//                     Math.Max(L.CalcularEstoque(),
//                         F.CalcularEstoque()))));

            
//             System.Console.WriteLine(maiorValor);
//         }

//     }

// }
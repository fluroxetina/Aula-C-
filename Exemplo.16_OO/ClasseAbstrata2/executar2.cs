// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo_16_OO
// {
//     public interface executar2
//     {
//         static void Main(string[] args)
//         {
//             // Livro livro1 = new Livro ("J.K. Rowling", 123456789, 1, 50.00);
//             // livro1.AtualizarPreco(100.00);
//             // System.Console.WriteLine(livro1.GetAutor());
//             // System.Console.WriteLine(livro1.GetPreco());

//             Produto [] produtos = new Produto[3];

//             produtos[0] = new Livro ("Autor1", 321654987, 1, 120.00);

//             produtos[1] = new CompactDisc (1, 170.00, "Artista1", "Gravadora1");

//             produtos[2] = new Livro ("Autor2", 321654987, 2, 10.00);

//             foreach (Produto item in produtos)
//             {
//                 System.Console.WriteLine("Codigo " + item.GetCodigo());
//                 System.Console.WriteLine("Preco " + item.GetPreco());
//                 item.AtualizarPreco((item.GetPreco() * 1.1));
//                 System.Console.WriteLine("Novo Preco " + item.GetPreco());
//                 System.Console.WriteLine();

//             }

//         }
//     }
// }
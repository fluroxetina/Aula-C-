// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo_16_OO
// {
//     public class  Livro : Produto
//     {
//         public string Autor;
//         public long Isbn; 

//         public Livro(string autor, long isbn, int codigo, double preco) : base(codigo, preco)
//         {
//             this.Autor = autor;
//             this.Isbn = isbn;
//         }

//         public override void SetPreco( double preco )
//         {
//             this.Preco = preco;
//         }

//         public override void SetCodigo( int codigo )
//         {
//             this.Codigo = codigo;
//         }

//         public override int GetCodigo()
//         {
//             return this.Codigo;
//         }

//         public override double GetPreco()
//         {
//             return this.Preco;
//         }

//         public override void AtualizarPreco(double preco)
//         { 
//             this.Preco = preco;
//         }
        

//         public void SetAutor(string autor)
//         {
//             this.Autor = autor;
//         }

//         public void SetIsbn(long isbn)
//         {
//             this.Isbn = isbn;
//         } 

//         public string GetAutor()
//         {
//             return this.Autor;
//         }

//         public long GetIsbn()
//         {
//             return this.Isbn;
//         }

        

            

        


//     }
// }
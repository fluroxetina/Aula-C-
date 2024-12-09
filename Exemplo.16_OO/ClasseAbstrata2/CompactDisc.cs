// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo_16_OO
// {
//     public class CompactDisc : Produto
//     {
//         public string Artista;
//         public string Gravador;

//         public CompactDisc(int codigo, double preco, string artista, string gravador) : base(codigo, preco)
//         {
//             this.Artista = artista;
//             this.Gravador = gravador;
//         }

//         public void SetArtista(string artista)
//         {
//             this.Artista = artista;
//         }

//         public void SetGravador(string gravador)
//         {
//             this.Gravador = gravador;
//         }

//         public string GetArtista()
//         {
//             return this.Artista;
//         }

//         public string GetGravador()
//         {
//             return this.Gravador;
//         }

//         public override void AtualizarPreco(double preco)
//         {
//             this.Preco = preco;
//         }

//         public override void SetCodigo( int codigo )
//         {
//             this.Codigo = codigo;
//         }
            
//         public override void SetPreco( double preco )
//         {
//             this.Preco = preco;
//         }

//         public override double GetPreco()
//         {
//             return this.Preco;
//         }

//         public override int GetCodigo()
//         {
//             return this.Codigo;
//         }
       
//     }
// }
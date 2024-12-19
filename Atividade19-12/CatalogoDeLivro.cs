using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade19_12
{
    public class CatalogoDeLivro
    {
        public List<Livros> Livros { get; set; } = new List<Livros>();

        public CatalogoDeLivro() 
        {
            Livros = new List<Livros>();
        }

        public void AdicionarLivro(Livros livro) 
        {
            Livros.Add(livro);
        }

        public void RemoverLivro(Livros livro) 
        {
            Livros.Remove(livro);
        }

        public void ExibirLivros()
        {
            System.Console.WriteLine("==============Livros==============");
            foreach (var livro in Livros)
            {
                Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}, Ano de Publicação: {livro.AnoDePublicacao}, Exemplares Disponíveis: {livro.ExemplaresDisponiveis}");
            }

        }

    }


}
using System;

namespace Atividade19_12
{
    class Executar 
    {
        static void Main(string[] args)
        {
            Livros livro1 = new Livros("O Senhor dos Aneis", "J.R.R Tolkien", new DateTime(300), 3);     
            Livros livro2 = new Livros("O Hobbit", "J.R.R Tolkien", new DateTime(300), 3);

            Leitor leitor = new Leitor("Joaquim", "111.111.111-11");
            Funcionario funcionario = new Funcionario("Joaquim", "111.111.111-11", "Mendigo");

            Biblioteca biblioteca = new Biblioteca("GravenaLandia", "rua1", new CatalogoDeLivro(), new List<Funcionario>());   
            Biblioteca biblioteca1 = new Biblioteca("GravenaHistory", "rua2", new CatalogoDeLivro(), new List<Funcionario>());
            CatalogoDeLivro catalogo = new CatalogoDeLivro();
            RedeDeBibliotecas redeBiblioteca = new RedeDeBibliotecas();

            redeBiblioteca.AdicionarBiblioteca(biblioteca);
            redeBiblioteca.AdicionarBiblioteca(biblioteca1);

            redeBiblioteca.ExibirBibliotecas();

            redeBiblioteca.RemoverBiblioteca(biblioteca);

            redeBiblioteca.ExibirBibliotecas();

            catalogo.AdicionarLivro(livro1);
            catalogo.AdicionarLivro(livro2);

            leitor.ConsultarLivrosDisponiveis(catalogo);

            catalogo.ExibirLivros();

            funcionario.RealizarEmprestimo(leitor, livro1);
            leitor.ConsultarLivrosDisponiveis(catalogo);
            funcionario.AtualizarCatalogo(catalogo, livro2);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade19_12
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; } 

        public Funcionario(string Nome, string CPF, string Cargo) : base(Nome, CPF)
        {
            this.Cargo = Cargo;
        }

        public void AtualizarCatalogo(CatalogoDeLivro catalogo, Livros livro)
        {
            catalogo.Livros.Add(livro);
        }

        public void RealizarEmprestimo(Leitor leitor, Livros livro) {
            if (livro.ExemplaresDisponiveis > 0){
                livro.ExemplaresDisponiveis--;
            }
        }
    }
}
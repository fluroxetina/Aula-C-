using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade19_12
{
    public class Leitor : Usuario
    {
        public Leitor(string Nome, string CPF) : base(Nome, CPF)
        {
            
        }

        public void ConsultarLivrosDisponiveis(CatalogoDeLivro catalogo)
        {
            catalogo.ExibirLivros();

        }

    }
}
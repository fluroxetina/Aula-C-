using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade19_12
{
    public class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime AnoDePublicacao { get; set; }
        public int ExemplaresDisponiveis { get; set; }

        public Livros(string titulo, string autor, DateTime anoDePublicacao, int exemplaresDisponiveis)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            ExemplaresDisponiveis = exemplaresDisponiveis;
        }
    }
}
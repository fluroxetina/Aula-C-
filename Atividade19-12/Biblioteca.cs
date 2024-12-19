using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade19_12
{
    public class Biblioteca {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public CatalogoDeLivro Catalogo { get; set; } = new CatalogoDeLivro();
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Biblioteca(string nome, string endereco, CatalogoDeLivro catalogo, List<Funcionario> funcionarios) {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Catalogo = catalogo;
            this.Funcionarios = funcionarios;
        }
    }
}
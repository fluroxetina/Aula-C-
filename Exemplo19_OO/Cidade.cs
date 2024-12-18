using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Cidade
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; }

        public Cidade(string nome, Estado estado)
        {
            this.Nome = nome;
            this.Estado = estado;
        }

    }
}
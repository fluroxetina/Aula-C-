using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Estado
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public Estado(string nome, string sigla)
        {
            this.Nome = nome;
            this.Sigla = sigla;
        }


    }
}


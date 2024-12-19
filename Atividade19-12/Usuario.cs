using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade19_12
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Usuario(string Nome, string CPF)
        {
            this.Nome = Nome;
            this.CPF = CPF;
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Endereco
    {
        public string Rua { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; } 

        public int CEP {get; set;}

        public Endereco(string rua, string cidade, string estado, int cep)
        {
            this.Rua = rua;
            this.Cidade = cidade;
            this.Estado = estado;
            this.CEP = cep;
        }

        public Endereco()
        {
            
        }
    }
}
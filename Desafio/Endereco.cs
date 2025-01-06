using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Endereco
    {
        // Utilizando propriedades auto-implementadas
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public int CEP { get; set; }

        // Construtor
        public Endereco(string rua, string cidade, Estado estado, int cep)
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }  
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }

        public Funcionario(string nome, DateTime nascimento, string cpf, Endereco endereco)
        {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.CPF = cpf;
            this.Endereco = endereco;
        }


    }
}
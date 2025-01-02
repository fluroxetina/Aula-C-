using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public class Pessoa
    {
        protected string Nome { get; set; }
        protected string Cpf { get; set; }
        

        public Pessoa(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public string GetNome()
        {
            return this.Nome;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public class Engenheiro : Pessoa
    {
        public int Crea { get; set; }

        public Engenheiro(string nome, string cpf, int crea) : base(nome, cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Crea = crea;
        }
    }
}
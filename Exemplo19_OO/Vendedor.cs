using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Vendedor : Funcionario
    {
        
        public EquipeVenda equipe { get; set; }

        
        public Vendedor(string nome, DateTime nascimento, string cpf, Endereco endereco, EquipeVenda equipe) : base(nome, nascimento, cpf, endereco)
        {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.equipe = equipe;
        }

        public double GetSalario()
        {
            return 1000.00;
        }
    }
}
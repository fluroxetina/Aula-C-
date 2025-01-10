using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade09_01
{
    public class Customer
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        public DateTime Dob { get; set; }

        public string CardNumber { get; set; }

        public string Cpf { get; set; }


        public Customer(string nome, Endereco endereco, DateTime dob, string cardNumber, string cpf)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Dob = dob;
            this.CardNumber = cardNumber;
            this.Cpf = cpf; 

        }

        public bool VereficarSenha(string senha)
        {
            if (senha == this.CardNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
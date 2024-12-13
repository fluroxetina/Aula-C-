using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo._17_OO
{
    public class Banco
    {
        public string Nome;
        public string NumConta{get; private set;}
        public double ValorInicial;
        private double Saldo;


        public Banco(string nome, string numConta)
        {
            this.Nome = nome;
            this.NumConta = numConta;
        }

        public Banco(string nome, string numConta, double valorInicial) : this(nome, numConta)
        {
            this.ValorInicial = valorInicial;
            this.Saldo += valorInicial;  
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.Saldo -= (valor)+5;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }
    }
}
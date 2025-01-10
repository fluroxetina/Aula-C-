using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade09_01
{
    public abstract class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; } 
        public List<Transaction> Historico { get; set; }

        // public Account(int number, double balance, List<Transaction> historico)
        // {
        //     Number = number;
        //     Balance = balance;
        //     Historico = historico;
        // }

        public void Deposito(double valor){}

        public void Saque(double valor){}

       
    }



    public class ContaCorrente : Account 
    {
        public double Saldo { get; set; }

        public int Number { get; set; }

         public List<Transaction> Historico { get; set; }

        public double Balance { 

            get => Saldo; 
            set => Saldo = value; 
  
        } 


        public ContaCorrente(int number, double balance, List<Transaction> historico, double saldo) 
        // : base(number, balance, historico)
        {
            this.Saldo = saldo;
            Historico = historico ?? new List<Transaction>();
           
            if(Saldo < 0)
            {
                throw new DomainException("Saldo negativo!");
            }
        }

        public void Saque(double valor)
        {
            if(valor > Saldo)
            {
                throw new DomainException("Saldo insuficiente!");
            }

            Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            if (valor < 0)
            {
                throw new DomainException("Valor inválido!");
            }

            Saldo += valor;
        }
    }

    public class ContaPoupanca : Account
    {
        public double Saldo { get; set; }

        public int Number { get; set; }

         public List<Transaction> Historico { get; set; }

        public double Balance { 

            get => Saldo; 
            set => Saldo = value; 
  
        } 

        public ContaPoupanca(int number, double balance, List<Transaction> historico, double saldo) 
        // : base(number, balance, historico)
        {
            this.Saldo = saldo;
            Historico = historico ?? new List<Transaction>();   
        }

        public void Saque(double valor)
        {
            if(valor > Saldo)
            {
                throw new DomainException("Saldo insuficiente!");
            }

            Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            if (valor < 0)
            {
                throw new DomainException("Valor inválido!");
            }

            Saldo += valor;
        }

    }

}
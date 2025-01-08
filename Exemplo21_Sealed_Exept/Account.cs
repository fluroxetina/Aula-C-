using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo21_Sealed_Exept
{
    public class Account
    {
        public int Number { get;  set; }
        public string Holder { get;  set; }
        public double Balance { get;  set; }
        public double WithdrawLimit { get;  set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithdrawLimit = withdrawLimit;

            
        }

        public void deposito(double Amount)
        {
            Balance = Balance + Amount;
            System.Console.WriteLine("Deposito realizado com sucesso!");
        }

        public void withdraw(double Amount) 
        {
            if (Amount > WithdrawLimit)
            {
                throw new DomainException("O limite de saque foi excedido!");
            }

            if (Amount > Balance)
            {
                throw new DomainException("Saldo insuficiente!");
            }

            Balance = Balance - Amount;
        }

        public override string ToString()
        {
            return $"Account {Number}, Holder: {Holder}, Balance: {Balance}";
        }


    }
}
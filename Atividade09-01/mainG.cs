using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade09_01
{
    public class mainG
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Banco");
            


            ContaCorrente contaCorrente = new ContaCorrente(1, 0.0, new List<Transaction>(), 0.0);

            double valorDeposito = 500.0;
            contaCorrente.Deposito(valorDeposito);
            // Console.WriteLine($"Depósito realizado: {valorDeposito:C}");
            // Console.WriteLine($"Saldo após depósito: {contaCorrente.Saldo:C}");

       
            double valorSaque = 200.0;
            contaCorrente.Saque(valorSaque);
            Console.WriteLine($"Saque realizado: {valorSaque:C}");
            Console.WriteLine($"Saldo após saque: {contaCorrente.Saldo:C}");

            Transaction transaction = new Transaction(1, DateTime.Now, TypeTransaction.DEPOSITO, valorDeposito, contaCorrente.Saldo);

           
            contaCorrente.Historico.Add(transaction);

            foreach (var item in contaCorrente.Historico)
            {
                Console.WriteLine(item.PostBalance);
            }
        }
    }   
}
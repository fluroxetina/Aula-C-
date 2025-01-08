using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo21_Sealed_Exept
{
    public class rodar
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero da sua conta: ");
            int numAccount = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Digite o seu saldo: ");
            double balance = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o seu limite de saque: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(numAccount, name, balance, withdrawLimit);

            System.Console.WriteLine("Conta: " + account);


            
           
        }
    }
}
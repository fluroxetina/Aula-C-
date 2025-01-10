using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade09_01
{
    public class ATM
    {
        public Endereco Location { get; set; } 
        public string ManagedBy { get; set; }



        public bool IdentifyCustomer(Customer customer)
        {
            if(customer.VereficarSenha(customer.CardNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void RealizarTransacao(Account account, Transaction transaction)
        {
            if (transaction.Type == TypeTransaction.DEPOSITO)
            {
                account.Deposito(transaction.Amount);
            }
            else if (transaction.Type == TypeTransaction.SAQUE)
            {
                account.Saque(transaction.Amount);
            }
            else
            {
                Console.WriteLine("Tipo de transação inválido!");
            }
        }
    }
}
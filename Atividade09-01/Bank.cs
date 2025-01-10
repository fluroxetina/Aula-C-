using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade09_01
{
    public class Bank
    {
        public int Code { get; set; }
        public Endereco endereco { get; set; } 

        public List<Account> contas { get; set; }

        public Bank(int code, Endereco endereco)
        {
            this.Code = code;
            this.endereco = endereco;
        }

        public void Manages(){}

        public void AdicionarConta(Account conta){

            if(conta != null){

                this.contas.Add(conta);
            }
        }

        public void ListarContas()
        {
            foreach (var conta in contas)
            {
                System.Console.WriteLine($"\n Numero da conta:{conta.Number}\n Saldo:{conta.Balance}");
            }
        }

        public Account BuscarPorNumero(int number)
        {    
            return contas.Find(x => x.Number == number);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class CartaoCredito : IPagamento, IAnuidade
    {
        public string NumCard {get; set;}
        public DateTime dataVencimento {get; set;}
        public double ValorAnuidade {get; set;}

        public CartaoCredito(string numCard, DateTime vencimento, double valorAnuidade)
        {
            this.NumCard = numCard;
            this.dataVencimento = vencimento;
            this.ValorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"Pagando {valor} com carta de credito");
        }

        public void ExibirComprovante()
        {
            System.Console.WriteLine($"Comprovante de pagamento com carta de credito");
        }

        public DateTime Vencimento()
        {
            return DateTime.Now.AddYears(1);
        }

        public double CalcularValorAnuidade()
        {
            return 100.0;
        }
        

    }
}
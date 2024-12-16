using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class Pix : IPagamento
    {
        public string ChavePix { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public Pix(string chavePix, string nome, string cpf, double valor, DateTime dataPagamento)
        {
            this.ChavePix = chavePix;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Valor = valor;
            this.DataPagamento = dataPagamento;
        }

        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"Pagando {valor} com Pix");
        }

        public void ExibirComprovante()
        {
            System.Console.WriteLine($"Comprovante de pagamento com Pix");
            System.Console.WriteLine($"Chave Pix: {ChavePix}");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Imposto
    {
        public double TotalVendas { get; set; }
        public double ValorTotal { get; set; }
        public Cliente Cliente { get; set; }

        public double CalcularValorFinal()
        {
            Imposto imposto = new Imposto();
            double valorFinal = 0;
            foreach (var produto in Produtos)
            {
                valorFinal += produto.CalcularPrecoFinal();
            }
            return valorFinal - imposto.CalcularImpostoVendas();
        }
    }
}
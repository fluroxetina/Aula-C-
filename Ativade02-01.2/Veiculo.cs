using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ativade02_01_2
{
    public abstract class Veiculo
    {
        public string Placa;
        public double ValorLocacao;
        public double Imposto;

        public Veiculo(string placa, double valorLocacao, double imposto)
        {
            this.Placa = placa;
            this.ValorLocacao = valorLocacao;
            this.Imposto = imposto;
        }

        public abstract double CalcularDiaria (int dias);


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ativade02_01_2
{
    public class Caminhao : Veiculo
    {
        public int Eixos;

        public Caminhao(string placa, double valorLocacao, double imposto, int eixos) : base(placa, valorLocacao, imposto)
        {
            this.Eixos = eixos;
        }

        public override double CalcularDiaria(int dias)
        {
            return (this.ValorLocacao + this.Imposto) * Eixos * dias;
        }
    }
}
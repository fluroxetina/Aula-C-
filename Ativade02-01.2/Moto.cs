using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ativade02_01_2
{
    public class Moto : Veiculo
    {
        public int Cilindrada;

        public Moto(string placa, double valorLocacao, double imposto, int cilindrada) : base(placa, valorLocacao, imposto)
        {
            this.Cilindrada = cilindrada;
        }

        public override double CalcularDiaria(int dias)
        {
            return (this.ValorLocacao + this.Imposto + this.Cilindrada) * dias ;
        }
    }

}
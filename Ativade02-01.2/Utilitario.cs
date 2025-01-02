using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ativade02_01_2
{
    public class Utilitario : Veiculo
    {
        public string Tipo;

        public Utilitario(string placa, double valorLocacao, double imposto, string tipo) : base(placa, valorLocacao, imposto)
        {
            this.Tipo = tipo;
        }

        public override double CalcularDiaria(int dias)
        {
            return (this.ValorLocacao + this.Imposto) * dias;
        }
    }
}
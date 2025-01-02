using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ativade02_01_2
{
    public class CarroDePasseio : Veiculo
    {
        public char Categoria;

        public CarroDePasseio(string placa, double valorLocacao, double imposto, char categoria) : base(placa, valorLocacao, imposto)
        {
            this.Categoria = categoria;
        }

        public override double CalcularDiaria(int dias)
        {
            return (this.ValorLocacao + this.Imposto) * dias;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class Circulo : IForma
    {
        public double Raio {get; set;}

        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }

        public double CalcualrArea()
        {   
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public void ExibirInfo()
        {
            System.Console.WriteLine("Circulo");
            System.Console.WriteLine("Raio" + Raio);
        }
    }
}

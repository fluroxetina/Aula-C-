using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
        }

        public override void Abrir()
        {
            System.Console.WriteLine("Abrir a porta do quarto");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Fechar a porta do quarto");
        }
    }
}
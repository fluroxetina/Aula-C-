using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Cozinha
    {
        public PortaCozinha PortaCozinha { get; set; }

        public bool Americana { get; set; }

        public float MetragemQuadrada { get; set; }

        public Cozinha(PortaCozinha portaCozinha, bool americana, float metragemQuadrada)
        {
            this.PortaCozinha = portaCozinha;
            this.Americana = americana;
            this.MetragemQuadrada = metragemQuadrada;
        }

        public void Entrar(PortaCozinha portaCozinha)
        {
            System.Console.WriteLine("Entrar na cozinha " + portaCozinha.Cor + " " + portaCozinha.Largura + " " + portaCozinha.Altura + " " + portaCozinha.Peso);
        }
    }
}
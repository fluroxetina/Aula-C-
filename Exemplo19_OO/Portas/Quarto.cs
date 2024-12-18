using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Quarto
    {
        public PortaQuarto portaQuarto { get; set; }

        public bool Banheiro { get; set; }

        public float MetragemQuadrada { get; set; }

        public Quarto(PortaQuarto portaQuarto, bool banheiro, float metragemQuadrada)
        {
            this.Banheiro = banheiro;
            this.MetragemQuadrada = metragemQuadrada;
            this.portaQuarto = new PortaQuarto("Branco", 0.80f, 2.00f, 1.00f);
        }
    }
}
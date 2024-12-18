using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Sala
    {
        public PortaSala PortaSala { get; set; }
        public float MetragemQuadrada { get; set; }
        public Porta PortaAuxiliar { get; set; }

        public Sala(PortaSala portaSala, float metragemQuadrada, Porta portaAuxiliar)
        {
            this.MetragemQuadrada = metragemQuadrada;
            this.PortaAuxiliar = portaAuxiliar;
            PortaSala = new PortaSala(portaSala.Cor, portaSala.Largura, portaSala.Altura, portaSala.Peso);
        }               

        public void AbrirPortaAuxiliar(PortaSala portaSalaAuxiliar)
        {
            PortaAuxiliar.Abrir();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class PortaCozinha : Porta
    {

        public PortaCozinha(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
            
        }
        public override void Abrir()
        {
            System.Console.WriteLine("Abrir a porta da cozinha");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Fechar a porta da cozinha");
        }   
    }
}
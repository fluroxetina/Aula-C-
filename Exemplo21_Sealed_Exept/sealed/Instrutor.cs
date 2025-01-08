using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo21_Sealed
{
    public class Instrutor : Coordenador
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salario base: " + salario * 1.3);
        }

        
    }
}
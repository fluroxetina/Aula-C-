using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class Formiga : Animal
    {
        public Formiga() : base(6)
        {

        }

        public void Comer()
        {
            System.Console.WriteLine("Comendo");
        }
    }
}
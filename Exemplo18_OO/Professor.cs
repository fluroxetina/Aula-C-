using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class Professor
    {
        public string Nome;

        public Professor(string nome)
        {
            this.Nome = nome;
        }  

        public void ensinar()
        {
            System.Console.WriteLine("Estou ensinando: " + this.Nome);
        }
    }
}
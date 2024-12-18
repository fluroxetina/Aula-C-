using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Professor
    {
        public string Nome { get; set; }

        public Professor(string nome)
        {
            this.Nome = nome;
        }

        public void Ensinar()
        {
            System.Console.WriteLine($"Professor: {this.Nome} esta ensinando");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Estudante
    {
        public string Nome { get; set; }

        public Estudante(string nome)
        {
            this.Nome = nome;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome: {this.Nome}");
        }
    }
}
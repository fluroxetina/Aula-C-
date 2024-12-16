using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class Peixe : Animal, IAnimalDeEstimacao
    {
        private string _Nome;

        public Peixe(int pernas) : base(pernas)
        {

        }

        public Peixe(string nome) : base(0)
        {
            this._Nome = nome;
        }

        public string getNome()
        {
            return this._Nome;
        }

        public void setNome(string nome)
        {
            this._Nome = nome;
        }

        public void Brinca()
        {
            System.Console.WriteLine("Brincando com peixe");
        }

        public void Comer()
        {
            System.Console.WriteLine("Comendo");
        }
    }
}
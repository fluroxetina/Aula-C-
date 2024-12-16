using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class Cachorro: Animal, IAnimalDeEstimacao
    {
        private string _Nome;

        public Cachorro(int pernas) : base(pernas)
        {
            
        }

        public Cachorro(string nome) : base(4)
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
            System.Console.WriteLine("Brincando");
        }

        public void Comer()
        {
            System.Console.WriteLine("Comendo");
        }

    }
}
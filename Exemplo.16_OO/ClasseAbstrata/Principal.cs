using System;

namespace Exemplo_16_OO
{
    public abstract class Forma
    {
        public string Nome;

        public Forma(string nome)
        {
            Nome = nome;

        }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro(); 

        public virtual void Imprimir()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Area: {CalcularArea()}");
            System.Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }
                    
    }
}
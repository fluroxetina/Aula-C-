using System;

namespace Exemplo_16_OO
{
    class Circulo : Forma
    {
        public double Raio;

        public Circulo(string nome, double raio) : base(nome)
        {
            this.Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;

        }

        public override void Imprimir()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Area: {CalcularArea()}");
            System.Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }
    }   
}
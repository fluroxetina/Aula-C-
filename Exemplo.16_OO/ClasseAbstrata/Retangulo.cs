using System;

namespace Exemplo_16_OO
{
    public class Retangulo : Forma 
    {
        public double Largura;
        public double Altura;

        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override void Imprimir()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Largura: {Largura}");
            System.Console.WriteLine($"Altura: {Altura}");
            System.Console.WriteLine($"Area: {CalcularArea()}");
            System.Console.WriteLine($"Perimetro: {CalcularPerimetro()}");  
        }

    }

}
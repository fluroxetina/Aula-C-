using System;

namespace Exercico
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Quartos");
            int Quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Preco");
            double Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Ultimo nome, idadee e altura");
            string[] x = Console.ReadLine().Split(' ');
            string ultimoNome = x[0];
            int idade = int.Parse(x[1]);
            double altura = double.Parse(x[2]);

            Console.WriteLine($"{nome} \n{Quartos} \n{Preco} \n{ultimoNome} \n{idade} \n{altura}"); 
        }


    }
}
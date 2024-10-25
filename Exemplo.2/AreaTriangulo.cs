using System;

namespace AreaTriangulo
{
    class Program
    {
         static void Teste()
        {
            Console.WriteLine("Escreva o valor da altura");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor da base do triangulo");
            int b = int.Parse(Console.ReadLine());

            int area = h * b / 2;

            Console.WriteLine(area);
            
        }
    }
}




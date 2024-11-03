using System;

namespace Exemplo3
{
    class Program
    {
        static void Exemplo()
        {
            System.Console.WriteLine("Escreva sua Idade: ");
            int Idade = int.Parse(Console.ReadLine());

            switch (Idade)
            {
                case >=18 && < 100:
                    System.Console.WriteLine("Maior de idade");
                    break;

                case < 18:
                    System.Console.WriteLine("Menor de idade");
                    break;

                default:
                    System.Console.WriteLine("Morreu");
                    break;

            }  
        }
    }
}




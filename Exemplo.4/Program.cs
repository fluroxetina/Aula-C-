using System;
using System.Collections.Generic;

namespace Exemplo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            int num = 0;

            while(num != -1){

                Console.WriteLine("Escreva um número:");
                num = int.Parse(Console.ReadLine());
                numeros.Add(num);
                
            }
            
            int maior = numeros[0];
            int menor = numeros[0];

            for (int x = 1; x < numeros.Count; x++)
            {
                if (numeros[x] > maior)
                {
                    maior = numeros[x];
                }

                if (numeros[x] < menor)
                {
                    menor = numeros[x];
                }
            }

            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }
    }
}

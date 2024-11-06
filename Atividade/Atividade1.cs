using System;

namespace Atividade
{
    class Atividade
    {
        static void Main(string[] args)
        {
            int[] num = new int [10]; 
            int soma = 0;

            for (int i = 0 ; i < 10 ; i++){
                System.Console.WriteLine("Digite um valor:");
                int n = int.Parse(Console.ReadLine());
                num[i] = n;
            }

           for(int s  = 0 ; s < 10 ; s++){
               soma += num[s];
           }

            System.Console.WriteLine($"A media dos valores é de {soma / 10}");
           
        }
    }
}
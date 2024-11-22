
1. Faça um programa que calcule a soma dos números de 1 a n, onde n é um número
inteiro fornecido pelo usuário.

using System;

namespace Exemplo10
{
    class Program
    {   

        static int Soma(int a, int b)
        {
            if (b == 0){
                return a;
            }
            else{
            
                return a + Soma(a + 1, b - 1);
            }
        }
        static void Main(string[] args)
        {
            int Lol = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Soma(0, Lol)); 
        }
    }
}

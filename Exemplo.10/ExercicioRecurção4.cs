using System;

namespace Exemplo10
{

    //5. Faça um programa que calcule a soma dos elementos de um vetor de inteiros.

    class Program
    {   

        static int SomaVetor(int[] a, int b, int soma = 0)
        {   
            
            if (b == a.Length){
                return soma;
            }

            else{
                
                return SomaVetor(a, b + 1, soma + a[b]);
            }


        }
        static void Main(string[] args)
        {
            int[ ] Lol = {1,2,3,4,5,6,7,8,9,10}; 

            System.Console.WriteLine(SomaVetor(Lol, 0));

        }
    }
}

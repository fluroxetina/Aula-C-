using System;

namespace Exemplo10
{

    //Faça um programa que calcule a média dos elementos de um vetor de inteiros.

    class Program
    {   

        // static int SomaVetor(int[] a, int b, int soma = 0)
        // {   
            
        //     if (b == a.Length){
        //         return soma;
        //     }

        //     else{
              
        //         return SomaVetor(a, b + 1, soma + a[b]);
        //     }

        // }


        static(int, double) SomaMediaVetor(int[] vetor , int index, int tamanho)
        {
            if(index < 0){
                return(0, 0.0);
            }
            
            (int somaParcial, double _) = SomaMediaVetor(vetor, index -1, tamanho);
            int somaTotal = somaParcial + vetor[index];

            double media = somaTotal / tamanho;
            return (somaTotal, media);
     
        }

        static void Main(string[] args)
        {
            int[ ] Lol = {1,2,3,4,5,6,7,8,9,10}; 
            var (somaTotal, media) = SomaMediaVetor(Lol, Lol.Length -1, Lol.Length);
            System.Console.WriteLine($"A soma total  {somaTotal} e a media  {media:F2}");

            // System.Console.WriteLine(SomaVetor(Lol, 0)/Lol.Length);


        }
    }
}

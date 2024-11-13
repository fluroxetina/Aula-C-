using System;

namespace Exemplo9
{
    class Program
    {

        static int RetonarPar(int[] a , int b )
        {
            if (b == 0 )
            {
                return 0;
            }else if(a[b - 1] % 2 != 0)

            {   // {   System.Console.WriteLine(a[b - 1] + RetonarPar(a , b - 1));
                return a[b - 1] + RetonarPar(a , b - 1);
            }
            else{
                return RetonarPar(a, b - 1);
            }
        }
        static void Main(string[] args)
        {
            int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; 
            System.Console.WriteLine($"Os numeros impares são {RetonarPar(vetor, 10)}"); 
        }
    }
}
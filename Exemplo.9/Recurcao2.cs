using System;

namespace Exemplo9
{
    class Program
    {
        static int[] ObterPares(int[] a, int b = 0 ){
            if(b >= a.Length){
                return new int[0];                
            }

            int [] pares = ObterPares(a , b + 1);

            if (a[b] % 2 == 0)
            {
                int[] result = new int[pares.Length + 1];
                result[0] = a[b];
                pares.CopyTo(result, 1);
                return result;
            }else {
                return pares;
            }

        }
        static void Main(string[] args)
        {
            int[] vetor = {1,2,3,4,5,6,7,8,9,10};
            int [] pares = ObterPares(vetor);

            foreach(int i in pares)
            {
                System.Console.WriteLine(i);
            } 
        }   
    }
}
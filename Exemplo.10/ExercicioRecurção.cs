
using System;

namespace Exemplo10
{
    class Program
    {   

        static int Multiplicação(int a, int b)
        {
            if (b == 1){
                
                return a;
            }
            else{

                return a * Multiplicação( a + 1, b - 1 );
            }
        }
        static void Main(string[] args)
        {
            int Lol = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Multiplicação(1, Lol)); 
        }
    }
}

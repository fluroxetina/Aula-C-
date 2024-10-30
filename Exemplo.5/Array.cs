using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            for (int i = 0 ; i < 10 ; i++){

                System.Console.WriteLine("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());
                array[i] = num;
            }

            System.Console.WriteLine("Ordem direta:");

            for (int x = 0; x < 10; x++){

                System.Console.WriteLine(array[x]);
            }


            System.Console.WriteLine("Ordem inversa: ");

            for (int x = 9; x >= 0; x--){

                System.Console.WriteLine(array[x]);
            }
        }
    }

}
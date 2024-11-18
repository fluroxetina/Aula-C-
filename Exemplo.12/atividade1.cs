using System;

namespace Exemplo12
{
    public class BubleSort
    {
        static void BubbleSort(int[] array)
        {
            int aux;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
        }

        static void Imprimir(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            
        }

        static void Main(string[] args)
        {
            int[] ar = new int [10];
            
            for(int i = 0 ; i < 10 ; i++)
            {
                Console.WriteLine("Digite um número");
                int num = int.Parse(Console.ReadLine());
                
                ar[i] = num;
            }

            Console.WriteLine("Array original:");
            Imprimir(ar);

            BubbleSort(ar);

            Console.WriteLine("\nArray ordenado:");
            Imprimir(ar);

            
        }
    }
}

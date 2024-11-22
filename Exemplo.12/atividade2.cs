using System;

namespace Exemplo11
{
    public class BubleSort
    {
        static void BubbleSort(int[] array)
        {
            int aux;
            int cont = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                        cont++;
                    }
                }
            }
            Console.WriteLine( "Interações: " + cont);
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
            int[] ar = {5, 1, 4, 2, 8};

            Console.WriteLine("Array original:");
            Imprimir(ar);

            BubbleSort(ar);

            Console.WriteLine("Array ordenado:");
            Imprimir(ar);

            
        }
    }
}


using System;

namespace SelectionSort
{
    public class SelectionSort1
    {   
        static void SelectionSort12(int[] array)
        {
            int menor, aux;

            for (int i = 0; i < array.Length; i++)
            {
                menor = i;
                for (int j = 0; j + 1 < array.Length; j++)
                {
                    if(array[j] > array[menor] )
                    {
                        menor = j; 
                    }
                    aux = array[i];
                    array[i] = array[menor];
                    array[menor] = aux;
                }
            }

        }

        static void Imprimir(int[] array)
        {
            for (int i = 0 ; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i] + " ");

            }
            System.Console.WriteLine();
        }   
        static void Main(string[] args)
        {
            int[] ar = { 11, 124, 356, 12, 1, 23, 123, 3, 123, 543, 123, 33, 56 };

            Imprimir(ar);

            SelectionSort12(ar);

            Imprimir(ar);
        }
    }
}
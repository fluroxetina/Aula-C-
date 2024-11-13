using System;

namespace InsertionSort
{
    public class InsertionSort
    {
        static void Ordenar(int[] array)
        {
            int aux, j;
            for (int i = 1 ; i < array.Length; i++)
            {
                aux = array[i]; 
                j = i - 1;
                while(j >= 0 && array[j] > aux)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j + 1] = aux;
            }
        }
        static void Imprimir(int[] array) 
        {
            for (int i = 0 ; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i] + " " );
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] num = { 12,324,24,35,45,7654,3,8,987654,321,1,9,09,87654,32};

            Imprimir(num);

            Ordenar(num);

            Imprimir(num);
            

        }
    }          
}


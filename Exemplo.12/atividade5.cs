using System;
using System.Diagnostics;
namespace testes
{
    class Program
    {
        
        static void SelectionSort12(int[] array)
        {
            int menor, aux;

            for (int i = 0; i < array.Length; i++)
            {
                menor = i;
                for (int j = 0; j + 1 < array.Length; j++)
                {
                    if(array[j] < array[menor] )
                    {
                        menor = j; 
                    }
                    aux = array[i];
                    array[i] = array[menor];
                    array[menor] = aux;
                }
            }

        }

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

        static void Main(string[] args)
        {
            int[] array = new int[1000];

            Random random = new Random();

        
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10000001); 
            }

            var sw = new Stopwatch();
            int[] arrayCopy = (int[])array.Clone();

            Console.WriteLine("Iniciando SelectionSort...");
            sw.Start();
            SelectionSort12(arrayCopy);
            sw.Stop();
            Console.WriteLine($"SelectionSort concluído em: {sw.ElapsedMilliseconds} ms");

            
            sw.Reset();
            arrayCopy = (int[])array.Clone(); 

            Console.WriteLine("\nIniciando InsertionSort...");
            sw.Start();
            Ordenar(arrayCopy);
            sw.Stop();
            Console.WriteLine($"InsertionSort concluído em: {sw.ElapsedMilliseconds} ms");

        
            sw.Reset();
            arrayCopy = (int[])array.Clone(); 

            Console.WriteLine("\nIniciando BubbleSort...");
            sw.Start();
            BubbleSort(arrayCopy);
            sw.Stop();
            Console.WriteLine($"BubbleSort concluído em: {sw.ElapsedMilliseconds} ms");
        }
    }
}
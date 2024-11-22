// using System;
// using System.Diagnostics;
// namespace testes
// {
//     class Program
//     {

          

//         public static void MergeSort112(int[] array, int inicio, int fim)
//         {
//             if (inicio < fim)
//             {
//                 int meio = (inicio + fim) / 2;

//                 MergeSort112(array, inicio, meio);
//                 MergeSort112(array, meio + 1, fim);

//                 Intercalar(array, inicio, meio, fim);
//             }
//         }

//         private static void Intercalar(int[] array, int inicio, int meio, int fim)
//         {
//             int[] aux = new int[fim - inicio + 1];
//             for (int j = inicio; j <= fim; j++)
//             {
//                 aux[j - inicio] = array[j];
//             }

//             int i1 = 0; 
//             int i2 = meio - inicio + 1; 
//             int i3 = inicio; 

//             while (i1 <= meio - inicio && i2 <= fim - inicio)
//             {
//                 if (aux[i1] < aux[i2])
//                 {
//                     array[i3] = aux[i1];
//                     i1++;
//                 }
//                 else
//                 {
//                     array[i3] = aux[i2];
//                     i2++;
//                 }
//                 i3++;
//             }

//             while (i1 <= meio - inicio)
//             {
//                 array[i3] = aux[i1];
//                 i1++;
//                 i3++;
//             }
//         }   

        
//         static void SelectionSort12(int[] array)
//         {
//             int menor, aux;

//             for (int i = 0; i < array.Length; i++)
//             {
//                 menor = i;
//                 for (int j = 0; j + 1 < array.Length; j++)
//                 {
//                     if(array[j] < array[menor] )
//                     {
//                         menor = j; 
//                     }
//                     aux = array[i];
//                     array[i] = array[menor];
//                     array[menor] = aux;
//                 }
//             }

//         }

//         static void Ordenar(int[] array)
//         {
//             int aux, j;
//             for (int i = 1 ; i < array.Length; i++)
//             {
//                 aux = array[i]; 
//                 j = i - 1;
//                 while(j >= 0 && array[j] > aux)
//                 {
//                     array[j+1] = array[j];
//                     j--;
//                 }
//                 array[j + 1] = aux;
//             }
//         }


//         static void BubbleSort(int[] array)
//         {
//             int aux;

//             for (int i = 0; i < array.Length; i++)
//             {
//                 for (int j = 0; j < array.Length - 1; j++)
//                 {
//                     if (array[j] > array[j + 1])
//                     {
//                         aux = array[j];
//                         array[j] = array[j + 1];
//                         array[j + 1] = aux;
//                     }
//                 }
//             }
//         }

//         static void Main(string[] args)
//         {
//             int[] array = new int[1000];

//             Random random = new Random();

        
//             for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] = random.Next(1, 10000001); 
//             }

//             var sw = new Stopwatch();
//             int[] arrayCopy = (int[])array.Clone();

//             Console.WriteLine("Iniciando SelectionSort...");
//             sw.Start();
//             SelectionSort12(arrayCopy);
//             sw.Stop();
//             Console.WriteLine($"SelectionSort concluído em: {sw.ElapsedMilliseconds} ms");

            
//             sw.Reset();
//             arrayCopy = (int[])array.Clone(); 

//             Console.WriteLine("\nIniciando InsertionSort...");
//             sw.Start();
//             Ordenar(arrayCopy);
//             sw.Stop();
//             Console.WriteLine($"InsertionSort concluído em: {sw.ElapsedMilliseconds} ms");

        
//             sw.Reset();
//             arrayCopy = (int[])array.Clone(); 

//             Console.WriteLine("\nIniciando BubbleSort...");
//             sw.Start();
//             BubbleSort(arrayCopy);
//             sw.Stop();
//             Console.WriteLine($"BubbleSort concluído em: {sw.ElapsedMilliseconds} ms");

//             sw.Reset();
//             arrayCopy = (int[])array.Clone(); 

//             Console.WriteLine("\nIniciando MergeSort...");
//             sw.Start();
//             MergeSort112(arrayCopy, 0, arrayCopy.Length - 1);
//             sw.Stop();
//             Console.WriteLine($"MergeSort concluído em: {sw.ElapsedMilliseconds} ms");

//         }
//     }
// }
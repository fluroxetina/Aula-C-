// using System;

// namespace testes
// {
//      public class Program
//     {

//                 public static void MergeSort112(int[] array, int inicio, int fim)
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

//         static void Main(string[] args)

//         {
//             int[] array = { 38, 27, 43, 3, 9, 82, 10 };
//             MergeSort112(array, 0, array.Length - 1);

//             foreach (var em in array)
//             {
//                 Console.WriteLine(em);
//             }
//         }
        
//     }
    
// }















// using System;

// namespace Exemplo12
// {
//     public class MergeSort
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

//         static void Main(string[] args)
//         {
//             int[] array = { 38, 27, 43, 3, 9, 82, 10 };
//             MergeSort112(array, 0, array.Length - 1);

//             foreach (var item in array)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }










// using System;

// namespace Exemplo12
// {
//     public class QuickSort
//     {   
//         public static void QuickSort12(int[] array, int inicio, int fim) 
//         {
//             if (inicio < fim )
//             {
//                 int p = Particionar(array, inicio, fim);
//                 QuickSort12(array, inicio, p -1);
//                 QuickSort12(array, p+1, fim);

//             }
//         }

//         public static int Particionar(int[] vetor, int inicio, int fim)
//         {
//             int pivo = vetor[fim];
//             int i = inicio -1;

//             for(int x = inicio; x < fim ; x++)
//             {
//                 if (vetor[x] < pivo){

//                     i++;
//                     int aux = vetor[i];
//                     vetor[i] = vetor[x];
//                     vetor[x] = aux;
//                 }
//             }
//             int aux2 = vetor [i+1]; 
//             vetor[i+1] = vetor[fim]; 
//             vetor[fim] = aux2;
//             return i + 1;
//         }




//         public static void Main(string[] args)
//         {
//             int[] array = { 1, 3, 54, 2, 4, 6, 8, 7, 9, 0 };
//             QuickSort12(array, 0, array.Length - 1);
//             foreach (var item in array)
//             {
//                 Console.WriteLine(item);
//             }
           
//         }
//     }
// }







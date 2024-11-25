// using System;

// namespace Exemplo_13
// {
    
    
//         public class FIla
//         {   


//             static int[] fila = new int[10];

//             static int inicio = 0;

//             static int fim = 0; 

//             static int cont = 0;

//             public static void Adicionar(int valor)
//             {
//                 if(cont < fila.Length) 
//                 {
//                     fila[fim] = valor;
//                     fim = (fim +1) % fila.Length;
//                     cont++; 
//                 }   
//                 else{
//                     System.Console.WriteLine("Fila cheia");
//                 }
//             }
            
//             public static void Remover()
//             {
//                 if(cont > 0)
//                 {
//                     fila[inicio] = 0;
//                     inicio = (inicio + 1) % fila.Length;
//                     cont--;

//                 }
//                 else{
                    
//                     System.Console.WriteLine("fila vazia");
//                 }
//             }

//             public static void Imprimir() 
//             {
//                 for (int i = 0 ; i < cont ; i++)
//                 {
//                     System.Console.WriteLine(fiça[(inicio + i) % fila.Length]);  
//                 }
//             }


//             public static void Primeiro()

//             {
//                 if(cont > 0 )
//                 {
//                     System.Console.WriteLine(fila[inicio]);
//                 }
//                 else{
//                     System.Console.WriteLine("fila vazia");
//                 }
//             }
//             static void Main(string[] args)
//             {

//                 Adicionar(1);
//                 Adicionar(2);
//                 Adicionar(3);
//                 Adicionar(4);
//                 Adicionar(5);
//                 Adicionar(6);
//                 Adicionar(7);
//                 Adicionar(8);
//                 Adicionar(9);
//                 Adicionar(10);
//                 System.Console.WriteLine("\nImprimindo a fila");
//                 Imprimir();
//                 System.Console.WriteLine("\nPrimeiro da fila");
//                 Primeiro();
//                 System.Console.WriteLine("\nRemovendo da fila");
//                 Remover();
//                 System.Console.WriteLine("\nImprimindo a fila");
//                 Imprimir();
//             }

//         }
    
// }
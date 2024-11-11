// using System ;

// namespace FunçãoRecursiva
// {
//     class Ref
//     {
//         static double Fatorial(int n)
//         {
//             if(n == 0)
//             {
//                 return 1;
//             }else{
//                 return n * Fatorial(n -1);
//             }
//         }


//         //fibonacci 
//         static int fibonacci(int n){
//             if (n == 0 || n == 1){
//                 return 1;

//             }else {
//                 return fibonacci(n - 1) + fibonacci(n - 2);
//             }
//         }

//         static int Fatorial2(int n)
//         {
//             int fatoria = 1;
//             for (int i - 1; i <= n; i++)
//             {
//                 fatoria *= i;
//             }
//             return fatoria;
//         }

//         static Fibonacci2(int n)
//         {
//             int a = 0, b =1 , c =1;
//             for(int i = 2; i <= n; i++) 
//             {
//                 c = a + b;
//                 a = b;
//                 b = c;
//             }
//             return c;
//         }
    
        
//         static void Main(string[] args)
//         {
//             // System.Console.WriteLine("Digite um valor: "); 
//             // int num = int.Parse(Console.ReadLine()); 
//             // System.Console.WriteLine($"O fatoria de {num} é igual a {Fatorial(num)}"); 
            

//             // System.Console.WriteLine("Digite um valor: "); 
//             // int num = int.Parse(Console.ReadLine()); 
//             // System.Console.WriteLine($"O fibonacci de um {num} é igual a {fibonacci(num)}");


//             int cont = 0;
//             while(true)
//             {
//                 cont++;
//                 System.Console.WriteLine(cont);
//             }
            


//         }
//     }
// }
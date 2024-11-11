// using System;

// namespace variaveisImpriclitas
// {
//     class Ref

//     {
//         static int Quadrado (int x )
//         {
//             return x * x;
//         }

//         //Usando ref
//         static void QuadradoRef(ref int x)
//         {
//             x = x * x;
//         }

//         //out 

//         static int QuadradoOut(out int x) 
//         {
//             x = 6;
//             return x * x;
//         }
//         static void Main(string[] args)
//         {
//             int a = 10;
//             System.Console.WriteLine(Quadrado(a));
//             System.Console.WriteLine(a);

//             QuadradoRef(ref a);
//             System.Console.WriteLine(a);

//             int b;
//             b = QuadradoOut(out b);
//             System.Console.WriteLine(b);
//         }
//     }
// }


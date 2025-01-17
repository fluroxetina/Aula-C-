// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo25_ClassTask
// {
//     public class ClassTask
//     {
//         //programa n fica travado esperando resultado função async = assincrona
//         static async Task Main(string[] args)
//         {
//             System.Console.WriteLine("Inicio do programa");
//             int resultado = await Soma(10,20);
//             System.Console.WriteLine($"Resultado: {resultado}");

//         }

//         static Task<int> Soma(int a, int b)
//         {
//             return Task.Run(() => {
//                 Task.Delay(10000).Wait();
//                 return a + b;
//             });
//         }
//     }
// }
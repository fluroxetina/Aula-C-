// using System;

// namespace Exemplo_13
// {
//     public class ListaDelegate
//     {
//         static delegate void FncaoDelegate(int valor);
//         string x = null;

//         static FuncaoDelegate? inicio = null;

//        static FuncaoDelegate CriarNo(int valor, FuncaoDelegate? proximo)
//        {
//             return valor =>
//             {
//                 System.Console.WriteLine(valor);
//                 proximo?.Invoke(valor);
//             }
//        }
//         static void Main(string[] args)
//         {
            
//         }
//     }
// }
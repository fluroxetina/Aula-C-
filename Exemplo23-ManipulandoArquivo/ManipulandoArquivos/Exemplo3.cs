// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

//namespace Exemplo23_ManipulandoArquivo
// {
//     public class Exemplo3
//     {
        
//         static void Exemplo3()
//         {
//             string inicioParh = @"C:\Users\arthurguedes\Desktop\teste1.txt";

//         try
//         {
//             using(FileStream fs = new FileStream(inicioParh, FileMode.Open))
//             {
//                 using(StreamReader sr = new StreamReader(fs))
//                 {
//                     string Line = sr.ReadLine();
//                     System.Console.WriteLine(Line);
//                 }
//             }
//         }
//         catch(IOException e)
//         {
//             System.Console.WriteLine("Ocorreu erro");
//             System.Console.WriteLine(e.Message);
//         }
//         }
        
//     }
// }
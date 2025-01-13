// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo23_ManipulandoArquivo
// {
//     public class Exemplo4
//     {
//         static void Main(string[] args)
//         {
//            string inicioParh = @"C:\Users\arthurguedes\Desktop\teste1.txt";
//             string finalParh = @"C:\Users\arthurguedes\Desktop\teste2.txt";

//             try
//             {
//                 string[] lines = File.ReadAllLines(inicioParh);
                
//                 using (StreamWriter sw = File.AppendText(finalParh))
//                 {
//                     foreach(string item in lines)
//                     {
//                         sw.WriteLine(item.ToUpper());
//                     }
//                 }
//             }
//             catch (Exception e)
//             {
                
//                 System.Console.WriteLine("Ocorreu erro");
//                 System.Console.WriteLine(e.Message);
//             } 
//         }
        
//     }
// }
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.Collections.Generic;

// namespace Exemplo23_ManipulandoArquivo
// {
//     public class Exemplo5
//     {
//         static void Main(string[] args)
//         {
//             string path = @"C:\Users\arthurguedes\Desktop\Teste";

//             try
//             {
//                 IEnumerable<string> pastas = Directory.EnumerateFileSystemEntries(path, "*.*", SearchOption.AllDirectories);

//                 System.Console.WriteLine("Pastas: ");
//                 foreach(string item in pastas)
//                 {
//                     System.Console.WriteLine(item);
//                 }

//                 IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

//                 foreach(string item in arquivos)
//                 {
//                     System.Console.WriteLine(item);
//                 }

//                 Directory.CreateDirectory(path + @"\Teste43");

//                 Directory.Delete(path + @"\Teste43");

//                 bool existe = Directory.Exists(path + @"\Teste1");
//                 System.Console.WriteLine("A pasta existe: " + existe);
//             }
//             catch (IOException e)
//             {
                
//                 System.Console.WriteLine("Ocorreu erro");
//                 System.Console.WriteLine(e.Message);
//             } 
//         }
//     }
// }
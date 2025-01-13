// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo23_ManipulandoArquivo
// {
//     public class Exempro2
//     {
        
//         static void Exempol2()
//         {
//             string inicioParh = @"C:\Users\arthurguedes\Desktop\teste1.txt";

//             FileStream fs = null;
//             StreamReader sr = null;

//             try
//             {
//                 fs = new FileStream(inicioParh, FileMode.Open);

//                 sr = new StreamReader(fs);
//                 string Line = sr.ReadLine();
//                 System.Console.WriteLine(Line);

//             }
//             catch(IOException e)
//             {
//                 System.Console.WriteLine("Ocorreu erro");
//                 System.Console.WriteLine(e.Message);
//             }
//             finally
//             {
//                 if(sr != null) sr.Close();
//                 if(fs != null) fs.Close();
//             }
//         }
//     }
// }
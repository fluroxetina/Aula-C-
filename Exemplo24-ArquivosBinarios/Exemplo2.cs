// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo24_ArquivosBinarios
// {
//     public class Exemplo2
//     {
//         static void Main(string[] args)
//         {
//             string filePath = "dados.bin";

//             using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
//             {
//                 int inteiro = reader.ReadInt32();
//                 string texto = reader.ReadString();
//                 double real = reader.ReadDouble();

//                 System.Console.WriteLine("Numero int do arquivo: " + inteiro);
//                 System.Console.WriteLine("Texto do arquivo: " + texto);
//                 System.Console.WriteLine("Numero real do arquivo: " + real);
//             }
//         }
//     }
// }
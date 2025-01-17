using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo24_ArquivosBinarios
{
    public class Exemplo1
    {
        static void Exe1()
        {
            string filePath = "dados.bin";

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(123);
                writer.Write("Testando");
                writer.Write(93.54);
            }
            System.Console.WriteLine("Dados criados " + filePath);
        }
    }
}
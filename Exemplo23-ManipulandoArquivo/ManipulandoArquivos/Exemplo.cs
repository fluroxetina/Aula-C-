using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo23_ManipulandoArquivo
{
    public class Exemplo
    {
        // static void Main(string[] args)
        public static void Exe1()
        {

            
            string inicioParh = @"C:\Users\arthurguedes\Desktop\teste1.txt";

            string finalFile= @"C:\Users\arthurguedes\Desktop\teste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(inicioParh);
                fileInfo.CopyTo(finalFile);

                string[] line = File.ReadAllLines(inicioParh);
                foreach (string item in line)
                {
                    System.Console.WriteLine(item);
                }

            }
            catch (IOException ex)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
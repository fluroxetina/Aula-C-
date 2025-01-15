using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Exemplo24_ArquivosBinarios
{
    public class Exemplo3_Encripty
    {
        static void Main(string[] args)
        {
            string original = "arquivo_original.txt";
            string encriptyFile = "arquivo_encripty.txt";
            string decrytFile = "arquivo_decryt.txt";

            // Criação do arquivo original
            File.WriteAllText(original, "O Kaua é gueixo");
            Console.WriteLine("Arquivo original criado");

            string password = "admin";

            // Encriptar o arquivo
            EncriptyFile(original, encriptyFile, password);
            Console.WriteLine("Arquivo encriptado");

            // Desencriptar o arquivo
            DecrytFile(encriptyFile, decrytFile, password);
            Console.WriteLine("Arquivo desencriptado");
        }

        static void EncriptyFile(string original, string encriptyFile, string password)
        {
            // Gerar chave e vetor de inicialização
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputFileStream = new FileStream(original, FileMode.Open, FileAccess.Read))
                using (FileStream outputFileStream = new FileStream(encriptyFile, FileMode.Create, FileAccess.Write))
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputFileStream.CopyTo(cryptoStream);
                }
            }
        }

        static void DecrytFile(string encriptyFile, string decrytFile, string password)
        {
            // Gerar chave e vetor de inicialização
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputFileStream = new FileStream(encriptyFile, FileMode.Open, FileAccess.Read))
                using (FileStream outputFileStream = new FileStream(decrytFile, FileMode.Create, FileAccess.Write))
                using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputFileStream);
                }
            }
        }
    }
}

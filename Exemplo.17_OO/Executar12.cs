using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo._17_OO
{
    public class Executar12
    {
        static void Main(string[] args)
        {
            Banco b3 = new Banco("Kauã", "5326");
            Banco b4 = new Banco("Kauã", "5326", 1000);
            

            b3.Depositar(1000);
            b3.Sacar(500);

            Console.WriteLine($"Nome do Usuario: {b3.Nome} \nValor inicial: {b4.ValorInicial} \nSaldo do banco: {b4.GetSaldo()}");
        }
    }
}

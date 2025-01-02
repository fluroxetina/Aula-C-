using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ativade02_01_2
{
    public class Executar
    {
        static void Main(string[] args)
        {
            CarroDePasseio carro = new CarroDePasseio("ABC1234", 100, 10, 'A');
            Console.WriteLine(carro.CalcularDiaria(5));

            Moto moto = new Moto("DEF1234", 50, 5, 250);
            Console.WriteLine(moto.CalcularDiaria(3));

            Utilitario utilitario = new Utilitario("GHI1234", 200, 20, "Caminhonete");
            Console.WriteLine(utilitario.CalcularDiaria(7));

            Caminhao caminhao = new Caminhao("JKL1234", 300, 30, 4);
            Console.WriteLine(caminhao.CalcularDiaria(5));

            
        }
    }
}
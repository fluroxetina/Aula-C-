using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_16_OO
{
    public class Executar3
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Henrique", 1000, "Desenvolvedor");
            System.Console.WriteLine("Funcionario: " + funcionario1.Nome);
            funcionario1.Nome = "UiuiDanthe";
            System.Console.WriteLine("Funcionario: " + funcionario1.Nome);

            Gerente gerente1 = new Gerente("Henrique", 6000 );
            System.Console.WriteLine("Gerente: " + gerente1.Nome);
            gerente1.Nome = "UiuiDanthe";
            System.Console.WriteLine("Gerente: " + gerente1.Nome);
            gerente1.AtualizarCargoGerente("Desenvolvedor");
        }

    }
}
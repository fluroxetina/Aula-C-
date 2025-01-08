using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo21_Sealed
{
    public sealed class Gerente : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salario basa:" + salario * 1.5);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerenciando...");
        }
    }
}
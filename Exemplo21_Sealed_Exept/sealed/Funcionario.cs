using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo21_Sealed
{
    public class Funcionario
    {
        public string Nome {get; set;}

        public virtual void Salario(int salario)
        {
            System.Console.WriteLine("Salario: R$" + salario);
        }

        public virtual void Trabalhar()
        {
            System.Console.WriteLine("Trabalhando...");
        }
    }
}
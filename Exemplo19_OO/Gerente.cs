using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Gerente : Funcionario
    {
        public Gerente(string Nome, DateTime Nascimento, string CPF, Endereco Endereco) : base(Nome, Nascimento, CPF, Endereco)
        {

        }

        public void GetSalario()
        {
            System.Console.WriteLine("10000 salarios");
        }

    }
}
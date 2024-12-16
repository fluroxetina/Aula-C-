using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo18_OO
{
    public class Universidade
    {
        public Professor professor;

        public Universidade(Professor professor)
        {
            this.professor = professor;
        }

        public void relizarAula()
        {
            System.Console.WriteLine($"Realizando a aula de {professor.Nome}");
        }
    }
}
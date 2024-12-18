using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Escola
    {
        private Estudante estudante;
        private Professor professor; 

        public Escola (string nomeEstudante)
        {
            estudante = new Estudante (nomeEstudante);
        }

        public void ContratarProf(Professor professor)
        {
            this.professor = professor;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine("Nome do estudante: " + estudante.Nome);
            System.Console.WriteLine("Nome do professor: " + professor.Nome);
            professor.Ensinar();
        }

    }
}
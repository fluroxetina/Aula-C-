using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public class UnidadeResidencial
    {
        protected double MetragemUnidade { get; set; }
        protected int NumQuartos { get; set; }
        protected int NumBanheiros { get; set; }   
        protected Pessoa Proprietario { get; set; }

        public UnidadeResidencial(double metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            this.MetragemUnidade = metragemUnidade;
            this.NumQuartos = numQuartos;
            this.NumBanheiros = numBanheiros;
            this.Proprietario = proprietario;
        }

        public double GetMetragemUnidade()
        {
            return MetragemUnidade;
        }

        public int GetNumQuartos()
        {
            return NumQuartos;
        }

        public int GetNumBanheiros()
        {
            return NumBanheiros;
        }

        public Pessoa GetProprietario()
        {
            return Proprietario;
        }

    }
}
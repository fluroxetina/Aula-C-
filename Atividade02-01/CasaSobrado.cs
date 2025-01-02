using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public class CasaSobrado : Casa
    {
        private int NumAndares { get; set; }

        public CasaSobrado(int numAndares, bool condominio, double metragemTotal, string endereco, Engenheiro responsavel) : base(condominio, metragemTotal, endereco, responsavel)
        {
            this.NumAndares = numAndares;
        }
    }
}
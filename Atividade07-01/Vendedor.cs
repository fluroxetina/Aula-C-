using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07_01
{
    public class Vendedor : Empregado
    {
        public double Comissao { get; set; }

        public Vendedor(string nome ,double salario, int licencasPremioRecebidas, double comissao) : base(nome, salario, licencasPremioRecebidas)
        {
            this.Comissao = comissao;
        }
    }
}
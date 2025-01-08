using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07_01
{
    public class Empregado : Pessoa
    {
        public double Salario { get; set; }

        public double SalarioMinimo = 240.00;

        public int LicencasPremioRecebidas { get; set; }

        public Empregado(string nome,double salario, int licencasPremioRecebidas ) : base(nome)
        {
            
            this.Salario = salario;
            this.LicencasPremioRecebidas = licencasPremioRecebidas;

            if(salario < SalarioMinimo)
            {
                System.Console.WriteLine("Salario invalido, Escravidão já acabou");
                this.Salario = 240.00;
            }

        }
    }
}
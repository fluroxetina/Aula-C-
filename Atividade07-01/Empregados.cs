using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07_01
{
    public class Empregados1 
    {
        private int NumeroMaximo = 50;

        private Empregado[] empregados = new Empregado[50];

        public int NumeroEmpregados { get; set; }

        public Empregados1(){}
        public void Insere(Empregado NovoEmpregado)
        {
            if(NumeroEmpregados < NumeroMaximo)
            {
                empregados[NumeroEmpregados] = NovoEmpregado;
                NumeroEmpregados++;
            }
        }

        public void Imprime()
        {
            for(int i = 0; i < this.NumeroEmpregados ; i++)
            {
                System.Console.WriteLine(empregados[i].Nome);
                System.Console.WriteLine(empregados[i].Salario);
            }
        }

        public double FolhaPagamento(Empregado empregados)
        {
            empregados.Salario = empregados.SalarioMinimo * (empregados.LicencasPremioRecebidas) * 0.1;
            return empregados.Salario;
        }
    }
}
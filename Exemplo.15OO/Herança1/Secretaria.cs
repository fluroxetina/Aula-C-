using System;

namespace Exemplo15_OO
{
    public class Secretaria : Funcionario
    {
        public string Ramal;

        public Secretaria(string nome, string CPF, double salario, string ramal ) : base(nome, CPF, salario)
        {
            this.Ramal = ramal;
        }

        public override double CalcularBonificacao()
        {
            return Salario * 0.05;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome} CPF: {CPF} Ramal: {Ramal} Salario: {Salario} Bonificacao {CalcularBonificacao()}");
        }


        
    }
}
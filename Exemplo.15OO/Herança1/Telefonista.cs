using System;

namespace Exemplo15_OO
{
    public class Telefonista : Funcionario
    {
        public string EstacaoDeTrabalho;

        public Telefonista(string nome, string CPF, double salario, string EstacaoDeTrabalho ) : base(nome, CPF, salario)
        {
            this.EstacaoDeTrabalho = EstacaoDeTrabalho;
        }

        public override double CalcularBonificacao()
        {
            return Salario * 0.05;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome} CPF: {CPF} EstacaoDeTrabalho: {EstacaoDeTrabalho} Salario: {Salario} Bonificacao {CalcularBonificacao()}");
        }

    }
}
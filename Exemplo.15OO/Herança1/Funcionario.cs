using System;

namespace Exemplo15_OO
{
    public class Funcionario
    {
        public string Nome;
        public string CPF;
        public double Salario;

        public Funcionario(string nome, string CPF, double salario)
        {
            this.Nome = nome;
            this.CPF = CPF;
            this.Salario = salario;

        }

        public virtual double CalcularBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome} CPF: {CPF} Salario: {Salario} Bonificacao {CalcularBonificacao()}" );
        }
    }
}
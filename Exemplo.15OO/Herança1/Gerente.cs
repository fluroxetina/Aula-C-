using System;

namespace Exemplo15_OO
{
    public class Genrente : Funcionario
    {
        public string Setor;
        public Genrente(string nome, string CPF, double salario, string setor) : base(nome ,CPF ,salario )
        {
            this.Setor = setor;
        }

        public override double CalcularBonificacao()
        {
            return Salario * 0.15;
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome} CPF: {CPF} Setor: {Setor} Salario: {Salario} Bonificacao {CalcularBonificacao()}");
        }
    }

}                                             
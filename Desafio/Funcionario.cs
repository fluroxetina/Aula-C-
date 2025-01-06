using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public abstract class Funcionario : IRelatorio
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int Cpf { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }

        public abstract double CalcularSalario();

        public abstract void GerarRelatorio();

    }  

    public class Gerete : Funcionario 
    {
        public double Bonus { get; set; } 

        public override double CalcularSalario()
        {
            return SalarioBase * 1.2;
        }



        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Nome: {Nome} CPF: {Cpf} Salario: {CalcularSalario()}");
        }
    } 

    public class Vendedor : Funcionario 
    {
        public double VendasRealizadas { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase * (VendasRealizadas * 0.1);
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Nome: {Nome} CPF: {Cpf} Salario: {CalcularSalario()} Vendas: {VendasRealizadas}");
        }
    }

    public class Padeiro : Funcionario 
    {
        public int HorasNoturas { get; set; } 

        public override double CalcularSalario() 
        {
            double adicionalNoturno = HorasNoturas * (SalarioBase * 0.25/160);
            return SalarioBase + adicionalNoturno;
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Nome: {Nome} CPF: {Cpf} Salario: {CalcularSalario()} Horas Noturnas: {HorasNoturas}");
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_16_OO
{
    public class Funcionario
    {
        public string Nome;
        private double Salario;
        protected string Cargo;

        public Funcionario(string nome, double salario, string cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {Nome}  \nCargo: {Cargo}");
            
        }
        protected void AtualizarCargo(string novoCargo)
        {
            this.Cargo = novoCargo;
            System.Console.WriteLine($"Cargo atualizado para: {Cargo}");    

        }

        private double CalcularImposto()
        {
            return Salario * 0.1;
        }
    }
}
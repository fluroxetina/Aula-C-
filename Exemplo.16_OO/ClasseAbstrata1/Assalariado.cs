// using System;

// namespace Exemplo_16_OO
// {
//     public class Assalariado : Empregado
//     {   
//         public double Salario;

//         public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome, sobrenome, cpf)
//         { 
//             this.Nome = nome;
//             this.Sobrenome = sobrenome;
//             this.Cpf = cpf;
//             this.Salario = salario;
//         }

//         public override double Vencimento()
//         {
//             return Salario;
//         }

//         public override void ImprimirVencimento()
//         {
//             System.Console.WriteLine($"Nome: {Nome} {Sobrenome}");
//             System.Console.WriteLine($"CPF: {Cpf}");
//             System.Console.WriteLine($"Vencimento: {Vencimento()}");
//         }
//     }

// }
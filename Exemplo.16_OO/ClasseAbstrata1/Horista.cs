// using System;

// namespace Exemplo_16_OO
// {
//     public class Horista : Empregado 
//     {
//         public double PrecoHora;
//         public double HorasTrabalhadas;

//         public Horista(double precoHora, double horasTrabalhadas, string nome, string sobrenome, string cpf) : base(nome, sobrenome, cpf)
//         {
//             this.PrecoHora = precoHora;
//             this.HorasTrabalhadas = horasTrabalhadas;
//         }

//         public override double Vencimento()
//         {
//             return PrecoHora * HorasTrabalhadas;
//         }

//         public override void ImprimirVencimento()
//         {
//             System.Console.WriteLine($"Nome: {Nome} {Sobrenome}");
//             System.Console.WriteLine($"CPF: {Cpf}");
//             System.Console.WriteLine($"Vencimento: {Vencimento()}");
//         }
//     }
// }
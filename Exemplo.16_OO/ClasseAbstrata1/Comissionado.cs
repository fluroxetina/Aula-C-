// using System;

// namespace Exemplo_16_OO
// {
//     public class Comissionado : Empregado
//     {
//         public double TotalVenda;
//         public double TaxaComissao;

//         public Comissionado(double totalVenda, double taxaComissao, string nome, string sobrenome, string cpf) : base(nome, sobrenome, cpf)
//         {
//             this.TotalVenda = totalVenda;
//             this.TaxaComissao = taxaComissao;
//         }

//         public override double Vencimento()
//         {
//             return TotalVenda * TaxaComissao;
//         }

//         public override void ImprimirVencimento()
//         {
//             System.Console.WriteLine($"Nome: {Nome} {Sobrenome}");
//             System.Console.WriteLine($"CPF: {Cpf}");
//             System.Console.WriteLine($"Vencimento: {Vencimento()}");
//         }
//     }
// }
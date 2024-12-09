// using System;

// namespace Exemplo_16_OO
// {
//     public abstract class Empregado
//     {
//         public string Nome;
//         public string Sobrenome;
//         public string Cpf;

//         public Empregado(string nome, string sobrenome, string cpf)
//         {
//             this.Nome = nome;
//             this.Sobrenome = sobrenome;
//             this.Cpf = cpf; 
//         }

//         public abstract double Vencimento();

//         public virtual void ImprimirVencimento()
//         {
//             System.Console.WriteLine($"Nome: {Nome} {Sobrenome}");
//             System.Console.WriteLine($"CPF: {Cpf}");
//             System.Console.WriteLine($"Vencimento: {Vencimento()}");
//         }
//     }
// }
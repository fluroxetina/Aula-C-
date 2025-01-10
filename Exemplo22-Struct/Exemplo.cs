using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo22_Struct
{
    public struct PessoaStruct
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaStruct(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    public class PessoaClass
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaClass(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    class Executar
    {
        public static void ExecutarExemplo1()
        {
            PessoaStruct pessoaStruct1 = new PessoaStruct("Willdanthe", 20);
            PessoaStruct pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Nome = "UiuiDanthe";  

            System.Console.WriteLine(pessoaStruct1);
            System.Console.WriteLine(pessoaStruct2);

            System.Console.WriteLine("---");
            PessoaClass pessoaClass1 = new PessoaClass("Willdanthe", 20);
            PessoaClass pessoaClass2 = pessoaClass1;
            pessoaClass2.Nome = "UiuiDanthe";  

            System.Console.WriteLine(pessoaClass1);
            System.Console.WriteLine(pessoaClass2);
        }
    }     
}
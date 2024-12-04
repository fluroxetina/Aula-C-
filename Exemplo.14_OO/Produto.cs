using System;

namespace Exemplo_14 
{
    public class Produto
    {
        public string Nome; 
        public double Preco;

        public Produto(string nome, double preco) 
        {
            this.Nome = nome;
            this.Preco = preco;
        } 

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {Nome} Preco: {Preco}");
        }

        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Notebook", 1000.00);
            Produto produto2 = new Produto("Notebook", 1000.00);
            produto1.ExibirInformacoes();
        }
    }
}
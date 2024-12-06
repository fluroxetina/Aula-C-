using System;

namespace Exemplo_15OO
{
    public class Petiscos
    {
        public string Nome;
        public double Preco;
        public int Qtd;



        public Petiscos()
        {
            Nome = "Coxinha";
            Preco = 5.00;
            Qtd = 10;
        }

        public Petiscos(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }

        public double CalcularEstoque()
        {
            return Preco * Qtd;
        }

        public string Exibir()
        {
            return $"O nome do produto é {Nome} seu preço é de {Preco} e sua quantidade em estoque é {Qtd}";
        }


    }
}
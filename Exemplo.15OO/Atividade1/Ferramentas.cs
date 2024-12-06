using System;

namespace Exemplo_15OO
{
    public record Ferramentas(string Nome, double Preco, int Qtd)
    {

    //   public string Nome;
    //     public double Preco;
    //     public int Qtd;

        
    //     public Ferramentas()
    //     {
    //         Nome = "Chave de Fenda";
    //         Preco  = 10.99;
    //         Qtd = 100;
    //     }
    //     public Ferramentas(string nome, double preco, int qtd)
    //     {
    //         this.Nome = nome;
    //         this.Preco = preco;
    //         this.Qtd = qtd;
    //     }

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
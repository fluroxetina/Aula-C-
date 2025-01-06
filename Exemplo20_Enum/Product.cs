using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo20_Enum
{
    public class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {Nome} Preco: {Preco}");
        }
    }
}
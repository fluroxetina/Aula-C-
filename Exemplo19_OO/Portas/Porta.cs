using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class Porta
    {
        public string Cor { get; set; }
        public float Largura { get; set; } 
        public float Altura { get; set; }   
        public double Peso { get; set; }

        public Porta(string cor, float largura, float altura, double peso)
        {
            this.Cor = cor;
            this.Largura = largura;
            this.Altura = altura;
            this.Peso = peso;
        }

        public virtual void Abrir()
        {
            System.Console.WriteLine("Abrir a porta");
        }
        public virtual void Fechar()
        {
            System.Console.WriteLine("Fechar a porta");
        }
    }
}
using System;

namespace Exemplo_15OO
{
    public class Animal
    {
        public string Nome;
        public bool Vivo;

        public Animal(string nome, bool vivo)
        {
            this.Nome = nome;
            this.Vivo = vivo;
        }

        public virtual void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {this.Nome} \nVivo{this.Vivo}");
        }
    }    
}
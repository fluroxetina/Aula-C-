using System;

namespace Exemplo_15OO
{
    public class Cobra : Animal
    {
        private bool Venenosa;

        public Cobra(string nome, bool vivo, bool venenoso):base(nome, vivo)
        {
            this.Venenosa = venenoso;
        }

        public void Alimento(string a)          
        {
            System.Console.WriteLine($"Se alimenta de {a}");
            
        }

        public void EVenenosa(bool v)
        {
            if(this.Venenosa == true)
            {
                System.Console.WriteLine("É venenosa");
            }
            else
            {
               System.Console.WriteLine("Não é venenosa");
            }
        }

        public override void ExibirDados()
        {
            System.Console.WriteLine($"O seu nome é {Nome}, {Vivo} ");

        }
    }
}
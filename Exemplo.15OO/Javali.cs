using System;


namespace Exemplo_15OO

{
    public class Javali : Animal
    {
        public bool Selvagem;

        public Javali(string nome, bool vivo, bool selvagem) : base(nome, vivo)
        {
            this.Selvagem = selvagem;
        }
        public int Velocidade()
        {
            return 100;
        }

        public void ESelvagem(bool s)
        {
            if(this.Selvagem)
            {
                System.Console.WriteLine("É selvagem");
            }
            else
            {
                System.Console.WriteLine("Não é");
            }
        }

        public override void ExibirDados()
        {
            System.Console.WriteLine($"Seu nome é {Nome}, {Vivo} sua velociadade é de {Velocidade()}km/h");

        }
    }
    
}
using System;

namespace Exemplo_15OO
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Javali javali1 = new Javali("Henrique", true, false);
            Cobra cobra1 = new Cobra("Kauã", true, true );






            cobra1.ExibirDados();
            cobra1.Alimento("churras");
            cobra1.EVenenosa(true);

            javali1.ExibirDados();
            javali1.ESelvagem(true);
        }
    }
}
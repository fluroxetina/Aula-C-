namespace Chama
{
    public class Mudificadores
    {

        public int soma (int a, int b)
        {
            return a + b;
        }

        static int subtrair(int a, int b)
        {
            return a - b;
        }
        static void Testes()
        {
            
            Mudificadores m = new Mudificadores();
            Console.WriteLine(m.soma(10, 20));


            System.Console.WriteLine(subtrair(20, 10));
        }
    }
}
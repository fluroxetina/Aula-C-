using  System;

namespace variaveisImpriclitas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pode receber qualquer tipo de dado
            var nome = "C#";
            System.Console.WriteLine(nome);
            System.Console.WriteLine(nome.GetType());


            var idada = 20;
            System.Console.WriteLine(idada);
            System.Console.WriteLine(idada.GetType());


            const double pi = 3.1415;
            System.Console.WriteLine(pi);
            System.Console.WriteLine(pi.GetType());


            //lista 

            var lista = new List<int>{1,2,3,4,5};

            System.Console.WriteLine(lista.GetType());
            //função pra listas os elementos 

            foreach(var i in lista)
            {
                System.Console.WriteLine(i);
            }
            
            //dicionario

            var dicionario = new Dictionary<string, int>
            {
                {"C#", 1},
                {"Java", 2},
                {"Python", 3}
            };

            foreach(var i in dicionario)
            {
                System.Console.WriteLine(i.Key);
            }
            
            


        }
        
    }
}

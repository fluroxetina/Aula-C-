using System;

namespace Calculadora
{
    class FazendoCalculos
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor da tabuada que deseja ver:");
            int valor = int.Parse(Console.ReadLine());
            
            for(int i = 0; i <= 10; i++){
                System.Console.WriteLine($"{i} x {valor} = {i*valor}");
                
            }





            for(int i = 0; i <= 10; i++){
                System.Console.WriteLine($"Tabuada do {i}");
                for(int x = 0; x <= 10; x++){
                    System.Console.WriteLine($"{i} x {x} = {i*x}");

                }

            }

            int cont = 0;
            int cont2 = 0;

            while(cont <= 10){
                System.Console.WriteLine($"{cont} x {cont2} = {cont*cont2}");
                if (cont2 == 10){
                    cont++;
                    cont2 = 0;
                }
                else{
                    cont2++;
                }
            }



        }
    }
 }

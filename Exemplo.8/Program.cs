using System;

namespace HA
{
    class Progrma
    {
        //Sobrecarga de função
        static int PraouImpar(int num){
            if(num % 2 == 0){
                return 0;
            }else{
                return 1;
            }
        }
        static string PraouImpar(double num){
            if(num % 2 == 0){
                return "Par";
            }else{
                return "Impar";
            }
        }

        static double Pi(){
            return 3.14;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um valor: ");
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine($" Numero é {PraouImpar(num)}");
        }
    }
}

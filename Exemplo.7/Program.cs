using System;

namespace Exemplo._7
{
    class Program
    {
        //função static que recebe dois números e retorna sua soma
        static int soma(int a, int b)
        {
            return a + b;
        }


        //Procedimento
        static void print(string msg)
        {
            System.Console.WriteLine(msg);
        }


        static double vezes(double a, double b, double c)
        {
            return a * b * c;
        }

        //função com valores no parametro
        static double vezes2(double a=10, double b=12, double c=20)
        {
            return a * b * c;
        }


        //função com array como parametro
        static int somaArray(int[] array)
        {
            int soma = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }
            return soma;
        }

        //função com matriz como parametro 
        static int somaMatriz(int[,] matriz)
        {
            int soam = 0;
            for(int i = 0; i < matriz.GetLength(0); i ++)
            {
                for (int j = 0 ; j < matriz.GetLength(1); j++)
                {
                    soam += matriz[i, j];
                }
            }
            return soam;
        }



        static void Tetse()
        {
            int a = 10;
            int b = 20;
            int resultado = soma(a, b);
            System.Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");



            print("Hello World!");

            double x = 18.5;
            double c = 10.5;
            double d = 3.5;

            double resultado2 = vezes(c, d, x);
            System.Console.WriteLine($"O resultado de {c} * {d} * 2.5 é igual a {resultado2}");

            double result = vezes2(1, 1, 1);
            System.Console.WriteLine(result);


            int[] vertor = {1, 2, 3, 4, 5};

            int resultado3 = somaArray(vertor);
            System.Console.WriteLine(resultado3);

            int[,]vaiTomando = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int resu = somaMatriz(vaiTomando);
            System.Console.WriteLine(resu);
        }
    }
}
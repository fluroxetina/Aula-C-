using System;

namespace Exemplo._2
{
    class Program
    {
        static void Teste()
        {
            int a = 20;
            int b = 3;
            int soma = a + b;
            System.Console.WriteLine(a + b);
            System.Console.WriteLine(a - b);
            System.Console.WriteLine(a * b);
            System.Console.WriteLine(a / b);
            System.Console.WriteLine(a % b);

            // Atribuição Aritmetica
            int c = 10;
            int d = 5;

            c += d;
            System.Console.WriteLine(c);

            c -= d;  
            System.Console.WriteLine(c);

            c *= d;
            System.Console.WriteLine(c);

            c /= d;    
            System.Console.WriteLine(c);

            // Operadores de Comparação
            int e = 10;
            int f = 5;

            System.Console.WriteLine(e > f);
            System.Console.WriteLine(e < f);
            System.Console.WriteLine(e >= f);
            System.Console.WriteLine(e <= f);
            System.Console.WriteLine(e == f);
            System.Console.WriteLine(e != f);


            // Operadores Logicos
            bool w = true;
            bool z = false;

            System.Console.WriteLine(w && z);
            System.Console.WriteLine(w || z);
            System.Console.WriteLine(!z);
            System.Console.WriteLine(!w);
            System.Console.WriteLine((!z && w) && (z || w));

            //Operador de incremento e decremento
            int x = 10;

            System.Console.WriteLine(x++);
            System.Console.WriteLine(x);
            System.Console.WriteLine(++x);
            System.Console.WriteLine(x);

            //decremento

            System.Console.WriteLine(x--);
            System.Console.WriteLine(x);
            System.Console.WriteLine(--x);
            System.Console.WriteLine(x);

            //Operadores bitwaise
            int y = 10;
            int v = 5;

            System.Console.WriteLine(y & v);
            System.Console.WriteLine(y | v);
            System.Console.WriteLine(y ^ v);
            System.Console.WriteLine(~y);
            System.Console.WriteLine(y << 1);
            System.Console.WriteLine(y >> 1);
        }
    }
}



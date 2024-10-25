// using System;

// namespace AreaCirculo
// {
//     class AreaCirculo
//     {
//         static void Teste()
//         {
//             double pi = 3.14;
//             int raio = 5;
//             double area = pi * Math.Pow(raio, 2);
//             Console.WriteLine(area);
//         }
//     }
// }


using System;

namespace AreaCirculo
{
    class AreaCirculo
    {   
        static void Teste()
        {
            Console.WriteLine("Digite o valor de raio: ");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14;
          
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine(area);
        }
    }

}

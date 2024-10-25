using System; 

namespace AreaQuadrado
{
    class AreaQuadrado
    {
        static void Teste()
        {
            Console.WriteLine("Digite o valor da largura: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da largura 2: ");
            int l2 = int.Parse(Console.ReadLine());
            
            int area = l1 * l2; 

            Console.WriteLine(area);

            
          
        
        }
    }
}
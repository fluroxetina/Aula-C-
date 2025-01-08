using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07_01
{
    public class Main1
    {
        static void Main(string[] args)
        {
            Empregados1[] empregados = new Empregados1[50];

            Vendedor vendedor = new Vendedor("Kaua", 1443.01, 10 , 500.00);
            Vendedor vendedor2 = new Vendedor("Lucas", 1034.66, 10 , 500.00);
            Vendedor vendedor3 = new Vendedor("Pedro", 100, 10 , 500.00);

            GerenteVendas gerenteVendas = new GerenteVendas("WiDanthe", 3900.99, Regiao.SUL, 500.42);


            Empregados1 empregados1 = new Empregados1();

            empregados1.Insere(vendedor);
            empregados1.Insere(vendedor2);
            empregados1.Insere(vendedor3);
            

            empregados1.Imprime();


        }
    }
}
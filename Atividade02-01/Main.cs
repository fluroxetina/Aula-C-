using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02_01
{
    public class Main1
    {
        static void Main(string[] args)
        {
            Engenheiro engenheiro = new Engenheiro("João", "123.456.789-10", 1234);

            Pessoa pessoa1 = new Pessoa("Kleber", "123.456.789-10");

            UnidadeResidencial unidade = new UnidadeResidencial(100.0, 2, 3, pessoa1);

            UnidadeResidencial unidade2 = new UnidadeResidencial(1002.0, 23, 23, pessoa1);

            UnidadeResidencial unidade3 = new UnidadeResidencial(1003.0, 210, 2323, pessoa1);


            Casa casa1 = new Casa(true, 100.0, "Rua A, 123", engenheiro);
            
            Predio predio = new Predio("Predio A", 5, 10, "Rua B, 456", engenheiro,  1000.0);

            CasaSobrado casaSobrado = new CasaSobrado(5, true, 200.0, "Rua C, 789", engenheiro);  
            
            predio.CadastrarUnidade(unidade);
            predio.CadastrarUnidade(unidade2);
            predio.CadastrarUnidade(unidade3);


            Console.WriteLine(predio.DescricaoDoImovel());

            int cont = 1;
            foreach(var unidade1 in predio.GetUnidade())
            {
                System.Console.WriteLine("\nUnidade " + cont);
                System.Console.WriteLine($"\n{unidade1.GetMetragemUnidade()}m2 \n{unidade1.GetNumQuartos()} quartos \n{unidade1.GetNumBanheiros()} banheiros \n{unidade1.GetProprietario().GetNome()} \n");
                cont++;
            }


           
        }
    }
}
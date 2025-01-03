using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;
            do
            {
                Console.Clear();
                System.Console.WriteLine("1 - Cadastrar Cliente\n2 - Cadastrar Produto\n3 - Registrar Venda\n4 - Estoque\n5 - Gerar Relatorio\n0 - Sair\n");
                System.Console.WriteLine("Digite a opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;

                    case 2:
                        CadastrarProduto(produtos, estoque);
                        break;

                    case 3:
                        RegistrarVenda(clientes, produtos, vendas, estoque);
                        break;

                    case 4:
                        VerificarEstoque(estoque);
                        break;

                    case 5:
                        GerarRelatorio(clientes, vendas);
                        break;

                    case 0:
                        System.Console.WriteLine("Saindo...");
                        break;

                    default:
                        System.Console.WriteLine("Opcao invalida!");
                        break;
                } 
            } while (opcao != 0);
        }
        public static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();

            System.Console.WriteLine("Digite o endereço do cliente:  (Rua, Cidade, Estado, CEP) ");
            string endereco = Console.ReadLine()

            Cliente cliente = new Cliente()
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                (
                    Rua = endereco.Split(",")[0],
                    Cidade = endereco.Split(",")[1],
                    Estado = endereco.Split(",")[2],
                    Cep = int.Parse(endereco.Split(",")[3])
                )
            };

            clientes.Add(cliente);
        }
    }
}
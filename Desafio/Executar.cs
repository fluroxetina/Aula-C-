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
                        GerarRelatorio(vendas);
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
            int cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();

            System.Console.WriteLine("Digite o endereço do cliente:  (Rua, Cidade, Estado, CEP) ");
            string endereco = Console.ReadLine();

            System.Console.WriteLine("Digiite a sigla do seu estado: ");
            string estado = Console.ReadLine();

            

            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {
                System.Console.WriteLine("Estado invalido!");
                return;
            }

            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                Cpf = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(",")[0],
                    Cidade = endereco.Split(",")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(endereco.Split(",")[2])
                }
            };

            clientes.Add(cliente);
        }

        private static void CadastrarProduto(List<Produto> produtos, Estoque estoque)
        {
            // Console.Clear();
            System.Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o codigo do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o preco de custo do produto: ");   
            double precoCusto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Apelido do produto: ");
            string apelido = Console.ReadLine();

            System.Console.WriteLine("Digite se o produto é perecivel: ");
            bool perecivel = bool.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o preco final do prudoto: ");
            double precoFinal = double.Parse(Console.ReadLine());

            
            

            System.Console.WriteLine("Cadastrar Fornecedor");

            System.Console.WriteLine("Digite o nome do fornecedor: ");
            string nomeFornecedor = Console.ReadLine();

            System.Console.WriteLine("Digite o CNPJ do fornecedor: ");
            string cnpjFornecedor = Console.ReadLine();

            System.Console.WriteLine("Digite o Endereço do fornecedor:  (Rua, Cidade, Estado, CEP) ");
            string enderecoFornecedor = Console.ReadLine();

            System.Console.WriteLine("Digite se é recorrente o fornecedor: ");
            bool recorrente = bool.Parse(Console.ReadLine());

            System.Console.WriteLine("Digiite a sigla do seu estado: ");
            string estado = Console.ReadLine();
            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {
                System.Console.WriteLine("Estado invalido!");
                return;
            }


            Fornecedor fornecedor = new Fornecedor()
            {
                Nome = nomeFornecedor,
                CNPJ = cnpjFornecedor,
                Endereco = new Endereco
                {
                    Rua = enderecoFornecedor.Split(",")[0],
                    Cidade = enderecoFornecedor.Split(",")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(enderecoFornecedor.Split(",")[2])
                },
                Recorrente = recorrente
            };

            Produto produto = new Produto()
            {
                Nome = nome,   
                Codigo = codigo,
                PrecoCusto = precoCusto,
                Apelido = apelido,
                Perecivel = perecivel,
                PrecoFinal = precoFinal,
                DataValidade = DateTime.Now,
                Fornecedor = fornecedor
            };

            produtos.Add(produto);  
            estoque.Produtos = produtos.ToArray();
            System.Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private static void RegistrarVenda(List<Cliente> clientes, List<Produto> produtos, List<Venda> vendas, Estoque estoque)
        {
            // Console.Clear();
            System.Console.WriteLine("Digite o CPF do cliente: ");
            int Cpf = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Cpf == Cpf);

            if (cliente == null) 
            {
                System.Console.WriteLine("Cliente nao encontrado!");
                return;
            }

            List<Produto> produtosVendidos = new List<Produto>();
            while(true)
            {
                System.Console.WriteLine("Digite o codigo do produto (0 Para finalizar): ");
                int codigo = int.Parse(Console.ReadLine());
                
                if(codigo == 0 ) break;

                Produto produto = produtos.Find(produto => produto.Codigo == codigo);
                if (produto != null)
                {
                    produtosVendidos.Add(produto);

                }   
                else{
                    System.Console.WriteLine("Produto nao encontrado!");
                }             

            }

            Venda venda = new Venda
            {
                Produtos = produtosVendidos.ToArray(),
                Data = DateTime.Now,
                Cliente = cliente, 
                FormaPagamento = "Cartão",
                QuantidadeParcelas = 3,
                ValorTotal = 0
            };

            vendas.Add(venda);
            System.Console.WriteLine("Venda registrada com sucesso!");
        }

        private static void VerificarEstoque(Estoque estoque)
        {
            // Console.Clear();
            System.Console.WriteLine("Digite o nome do produto: ");

            if(estoque.Produtos != null)
            {
                for(int i = 0; i < estoque.Produtos.Length; i++) 
                {
                    System.Console.WriteLine($"Nome do produto: {estoque.Produtos[i].Nome}");
                    System.Console.WriteLine($"Codigo do produto: {estoque.Produtos[i].Codigo}");
                    System.Console.WriteLine($"Preco de custo do produto: {estoque.Produtos[i].PrecoCusto}");
                    System.Console.WriteLine($"Apelido do produto: {estoque.Produtos[i].Apelido}");

                }
            }

        }

        private static void GerarRelatorio(List<Venda> vendas)
        {
            // Console.Clear();
            System.Console.WriteLine("Gerar relatorio");
            if(vendas != null)
            {
                foreach(var venda in vendas)
                {
                    System.Console.WriteLine("Data: " + venda.Data);
                    System.Console.WriteLine("Forma de pagamento: " + venda.FormaPagamento);
                    System.Console.WriteLine("Valor Total: " + venda.ValorTotal);
                    System.Console.WriteLine("Forma de Pagamento: " + venda.FormaPagamento);
                    System.Console.WriteLine("Quantidade de parcelas: " + venda.QuantidadeParcelas);
                }
            }
            else
            {
                System.Console.WriteLine("Vendas nao encontradas!");
            }

        }

        private static Dictionary<Estado, string> ApelidosPorEstado = new Dictionary<Estado, string> 
        {
            {Estado.SP, "Chipa" },
            {Estado.MS, "Chipa" },
            {Estado.MG, "Pão de quiejo"},
            {Estado.RJ, "Bixcoito"},
            {Estado.BA, "Acarajé"},
        };
        
    
    }
}
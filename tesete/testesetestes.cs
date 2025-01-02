using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Venda
    {
        public list<Produto> Produtos { get; set; }

        public DateTime DataVenda { get; set; }

        public Vendedor Vendedor { get; set; }

        public Pagamento Pagamento { get; set; }    

        public double Total { get; set; }

        public Venda(string FormaPagamento, bool Prazo , int QuantidadeParcelas ,DateTime dataVenda, Vendedor vendedor, Pagamentos pagamentos, List<Produto> produtos) : base(FormaPagamento, Prazo, QuantidadeParcelas)
        {
            this.DataVenda = dataVenda;
            this.Vendedor = vendedor;
            this.Pagamento = pagamentos;
            this.Produtos = produtos;
            this.Total = produtos.Sum(p => p.Preco);
        }
        
    }
}
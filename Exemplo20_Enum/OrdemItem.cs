using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo20_Enum
{
    public class OrderItem
    {
        public int Quantidade;
        public double Preco;
        public OrderItem(int quantidade, double preco)
        {
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }   
    }
}
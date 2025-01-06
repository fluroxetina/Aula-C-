using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo20_Enum
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order(DateTime moment, OrderStatus status)
        {
            this.Moment = moment;
            this.Status = status;
        }

        public void AddItem(OrderItem item)
        {
            
        }

        public void RemoverItem(OrderItem item)
        {

        }

        public double Total()
        {
            return 0;
        }
    }
}
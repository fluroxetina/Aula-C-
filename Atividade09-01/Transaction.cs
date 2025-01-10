using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade09_01
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Data { get; set; }
        public TypeTransaction Type { get; set; }
        public double Amount { get; set; }
        public double PostBalance { get; set; }

        public Transaction(int transactionId, DateTime data, TypeTransaction type, double amount, double postBalance)
        {
            this.TransactionId = transactionId;
            this.Data = data;
            this.Type = type;
            this.Amount = amount;
            this.PostBalance = postBalance;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public struct Transaction
    {
        private decimal transactionCost;

        public Transaction(decimal amount, Account trans, Account rec, decimal transactionCost)
        {
            this.transactionCost = transactionCost;
            Amount = amount;
            DateTimeOfTransaction = DateTime.Now;
            Receiver = rec;
            Transmitter = trans;
        }

        public decimal TransactionCost
        {
            get { return transactionCost; }
            private set { transactionCost = value; }
        }

        public Account Receiver { get; private set; }
        public Account Transmitter { get; private set; }
        public DateTime DateTimeOfTransaction { get; private set; }
        public decimal Amount { get; private set; }

    }
}

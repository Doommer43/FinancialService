using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public abstract class Account
    {
        public Customer Owner { get; private set; }
        public decimal Balance { get; private set; }
        public string AccountNumber { get; private set; }
        public IReadOnlyCollection<Transaction> Transactions { get; private set; }

        public bool Desposit (Transaction t)
        {
            throw new NotImplementedException();
        }

        public bool Withdraw (Transaction t)
        {
            if(t.Amount > Balance)
            {
                Balance -= t.Amount;
            }
            throw new NotImplementedException();
        }

        public decimal CalculateCostOfMonth(Month month)
        {
            decimal cost = 0;
            foreach (Transaction t in Transactions)
            {
                if((Month)t.DateTimeOfTransaction.Month == month)
                {
                    cost += Owner.TransactionCost;
                }
            }
            return cost;
        }

    }
}

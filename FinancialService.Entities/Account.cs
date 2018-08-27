using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public abstract class Account
    {
        private decimal balance;
        private string accountNumber;
        private IReadOnlyCollection<Transaction> transactions;
        private Customer customer;

        protected Account(string accountNumber, Customer customer, decimal balance = 0)
        {
            Balance = balance;
            AccountNumber = accountNumber;
            this.customer = customer;
        }

        #region Properties
        public IReadOnlyCollection<Transaction> Transactions
        {
            get { return transactions; }
            private set { transactions = value; }
        }


        public string AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        #endregion
        
        public bool Desposit (Transaction t)
        {
            throw new NotImplementedException();
        }

        public bool Withdraw (Transaction t)
        {
            if(t.Amount > Balance)
            {
                Balance -= t.Amount;
                return true;
            }
            return false;
        }

        public decimal CalculateCostOfMonth(Month month)
        {
            decimal cost = 0;
            foreach (Transaction t in Transactions)
            {
                if((Month)t.DateTimeOfTransaction.Month == month)
                {
                    cost += t.TransactionCost;
                }
            }
            return cost;
        }

    }
}

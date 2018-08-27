using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class SavingAccount : Account
    {
        private decimal interest;

        public SavingAccount(string accountNumber, Customer customer, decimal interest) : base(accountNumber, customer)
        {
            this.interest = interest;
        }

        public SavingAccount(string accountNumber, Customer customer, decimal interest, decimal balance) : base(accountNumber, customer, balance)
        {
            this.interest = interest;
        }

        public decimal Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public decimal AddInterest()
        {
            return Balance * Interest;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class CheckingAccount : Account
    {
        private const int NoMonthlyFreeTransactions = 20;
        public Customer customer;

        public CheckingAccount(string accountnumber, Customer customer) : base (accountnumber, customer)
        {
            this.customer = customer;
        }

        public CheckingAccount(string accountnumber, Customer customer, decimal balance) : base(accountnumber, customer, balance)
        {

        }
    }
}

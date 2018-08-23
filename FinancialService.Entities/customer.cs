using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class Customer
    {
        public Customer(string name, string cPR, IReadOnlyCollection<Account> accounts, decimal transactionCost = (decimal)1.95, decimal monthlyAccountFee = 15)
        {
            TransactionCost = transactionCost;
            MonthlyAccountFee = monthlyAccountFee;
            CPR = cPR;
            Name = name;
            Accounts = accounts;
        }

        public virtual decimal TransactionCost { get; }
        public virtual decimal MonthlyAccountFee { get; }
        public string CPR { get; }
        public string Name { get; set; }
        public IReadOnlyCollection<Account> Accounts { get; }



        public decimal CalculateCostOfMonth (Month month)
        {
            decimal cost = MonthlyAccountFee;
            Month m = (Month)DateTime.Today.Month;
            foreach (Account acc in Accounts)
            {
                cost += (acc.CalculateCostOfMonth(m) * TransactionCost);
            }
            return cost;
        }
    }
}

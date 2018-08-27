using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class Customer
    {
        private string cpr;
        private string name;
        private IReadOnlyCollection<Account> accounts;
        public Customer(string name, string cPR)
        {
            CPR = cPR;
            Name = name;
        }
        
        public virtual decimal TransactionCost { get => 1.95M; }
        public virtual decimal MonthlyAccountFee { get => 15; }
        public string Name { get => name; set => name = value; }
        public string CPR { get => name; private set => name = value; }
        public IReadOnlyCollection<Account> Accounts { get => accounts; private set => accounts = value; }

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

        public bool AddAccount(int type, string number)
        {
            switch (type)
            {
                case 1:
                    SavingAccount sacc = new SavingAccount(number, this, 8);
                    break;
                case 2:
                    CheckingAccount cacc = new CheckingAccount(number, this);
                    break;
                default:
                    return false;
            } return true;
        }
        public bool AddAccount(int type, string number, decimal balance)
        {
            switch (type)
            {
                case 1:
                    SavingAccount sacc = new SavingAccount(number, this, 8, balance);
                    break;
                case 2:
                    CheckingAccount cacc = new CheckingAccount(number, this, balance);
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}

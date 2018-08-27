using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class PremiumCustomer : Customer
    {
        public PremiumCustomer(string name, string cPR) : base(name, cPR)
        {

        }

        public override decimal TransactionCost => 1.2M;
        public override decimal MonthlyAccountFee => 12;
    }
}

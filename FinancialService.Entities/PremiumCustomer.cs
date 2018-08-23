using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class PremiumCustomer : Customer
    {
        public override decimal TransactionCost { get; }
        public override decimal MonthlyAccountFee { get; }
    }
}

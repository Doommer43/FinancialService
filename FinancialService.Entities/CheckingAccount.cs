using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class CheckingAccount : Account
    {
        public const int NoMonthlyFreeTransactions = 20;
    }
}

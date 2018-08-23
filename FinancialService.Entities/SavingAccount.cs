using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public class SavingAccount : Account
    {
        public decimal Interest { get; set; }
        public decimal AddInterest()
        {
            throw new NotImplementedException();
        }
    }
}

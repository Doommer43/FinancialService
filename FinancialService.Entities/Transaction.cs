using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialService.Entities
{
    public struct Transaction
    {
        public Account Receiver { get; private set; }
        public Account Transmitter { get; private set; }
        public DateTime DateTimeOfTransaction { get; private set; }
        public decimal Amount { get; private set; }

    }
}

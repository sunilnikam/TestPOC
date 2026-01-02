using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Class
{
    internal class Transaction
    {
        public int TransactionId { get; set; }
        public string AssetClass { get; set; }
        public decimal Amount { get; set; }
    }
}

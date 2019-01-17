using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class PaymentType
    {
        private string Type { get; set; }
        private double Amount { get; set; }

        public PaymentType(string type, double amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}

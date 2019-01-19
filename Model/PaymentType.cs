using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaymentType
    {
        public const string Membership = "membership";
        public const string MutualAidLow = "mutual_aid_low";
        public const string MutualAidHigh = "mutual_aid_high";

        private string Type { get; set; }
        private double Amount { get; set; }

        public PaymentType(string type, double amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaymentType
    {
        public enum TypeEnum
        {
            Membership = 1, 
            MutualAidLow,
            MutualAidHigh
        }
        
        public virtual TypeEnum Type { get; set; }
        public virtual double Amount { get; set; }

        public PaymentType()
        {

        }
        public PaymentType(TypeEnum type, double amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Payment
    {
        private PaymentType Type { get; }
        private DateTime ForYear { get; }

        public Payment(PaymentType type, DateTime forYear)
        {
            Type = type;
            ForYear = forYear;
        }
    }
}

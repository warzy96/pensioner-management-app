using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Payment
    {
        public int Id { get; protected set; }
        public Pensioner Pensioner { get; protected set; }
        public PaymentType Type { get; protected set; }
        public DateTime ForYear { get; protected set; }

        public Payment(Pensioner pensioner, PaymentType type, DateTime forYear)
        {
            Pensioner = pensioner;
            Type = type;
            ForYear = forYear;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Payment
    {
        public virtual int Id { get; set; }
        public virtual Pensioner Pensioner { get; set; }
        public virtual PaymentType Type { get; set; }
        public virtual DateTime ForYear { get; set; }
        public virtual bool IsPayed { get; set; }

        public Payment()
        {
        }
        public Payment(Pensioner pensioner, PaymentType type, DateTime forYear)
        {
            Pensioner = pensioner;
            Type = type;
            ForYear = forYear;
            IsPayed = false;
        }

        public Payment(Pensioner pensioner, PaymentType type, DateTime forYear, bool isPayed)
        {
            Pensioner = pensioner;
            Type = type;
            ForYear = forYear;
            IsPayed = isPayed;
        }
    }
}

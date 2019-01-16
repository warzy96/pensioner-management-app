using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Payment
    {
        private string PensionerOib { get; }
        private DateTime ForYear { get; }
        private double? FuneralFee { get; set; }
        private double? Fee { get; set; }
        private double? OtherExpenses { get; set; }

        public Payment(DateTime forYear, string pensionerOib = null, 
            double? funeralFee = default(double?), double? fee = default(double?),
            double? otherExpenses = default(double?))
        {
            PensionerOib = pensionerOib ?? throw new ArgumentNullException(nameof(pensionerOib));
            ForYear = forYear;
            FuneralFee = funeralFee;
            Fee = fee;
            OtherExpenses = otherExpenses;
        }
    }
}

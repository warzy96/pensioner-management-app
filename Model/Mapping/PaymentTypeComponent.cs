using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Model.Mapping
{
    class PaymentTypeComponent : ComponentMap<PaymentType>
    {
        public PaymentTypeComponent()
        {
            Map(x => x.Amount).Not.Nullable();
            Map(x => x.Type).CustomType<int>();
        }
    }
}

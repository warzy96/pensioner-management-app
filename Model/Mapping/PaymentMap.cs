using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Model.Mapping
{
    class PaymentMap : ClassMap<Payment>
    {
        public PaymentMap()
        {
            References(x => x.Pensioner);
            Id(x => x.Id).GeneratedBy.Native();
            Component(x => x.Type);
            Map(x => x.ForYear);
        }
    }
}

using FluentNHibernate.Mapping;
using Model;

namespace DataAccessLayer.Mapping
{
    class PaymentMap : ClassMap<Payment>
    {
        public PaymentMap()
        {
            References(x => x.Pensioner);
            Id(x => x.Id).GeneratedBy.Native();
            Component(x => x.Type);
            Map(x => x.ForYear);
            Map(x => x.IsPayed);
        }
    }
}

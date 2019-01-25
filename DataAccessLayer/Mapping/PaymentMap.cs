using FluentNHibernate.Mapping;
using Model;

namespace DataAccessLayer.Mapping
{
    class PaymentMap : ClassMap<Payment>
    {
        public PaymentMap()
        {
            Id(x => x.Id).GeneratedBy.Native();
            References(x => x.Pensioner);
            Component(x => x.Type);
            Map(x => x.ForYear).Not.Nullable();
            Map(x => x.IsPayed).Not.Nullable();
        }
    }
}

using FluentNHibernate.Mapping;
using Model;

namespace DataAccessLayer.Mapping
{
    internal class PaymentTypeMap : ClassMap<PaymentType>
    {
        public PaymentTypeMap()
        {
            Map(x => x.Amount).Not.Nullable();
            Map(x => x.Type).CustomType<int>();
            References(x => x.Pensioner);
            Id(x => x.Id).GeneratedBy.Native();
        }
    }
}

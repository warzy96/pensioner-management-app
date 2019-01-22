using FluentNHibernate.Mapping;
using Model;

namespace DataAccessLayer.Mapping
{
    internal class PaymentTypeMap : ClassMap<PaymentType>
    {
        public PaymentTypeMap()
        {
            Map(x => x.Amount).Not.Nullable();
            Id(x => x.Type).CustomType<int>();
        }
    }
}

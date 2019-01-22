using FluentNHibernate.Mapping;
using Model;

namespace DataAccessLayer.Mapping
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

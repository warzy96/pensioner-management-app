using FluentNHibernate.Mapping;

namespace Model.Mapping
{
    internal class AddressMap : ComponentMap<Address>
    {
        public AddressMap()
        {
            Map(x => x.City).Not.Nullable();
            Map(x => x.PostalCode).Not.Nullable();
            Map(x => x.Street).Not.Nullable();
            Map(x => x.Town).Not.Nullable();
        }
    }
}

using FluentNHibernate.Mapping;

namespace Model.Mapping
{
    public class PensionerMap : ClassMap<Pensioner>
    {
        public PensionerMap()
        {
            Id(x => x.Oib);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.DateOfBirth).Not.Nullable();
            Map(x => x.Id).Not.Nullable().Unique();
            Map(x => x.PlaceOfBirth);
            Map(x => x.Surname).Not.Nullable();
            Map(x => x.MembershipStart).Not.Nullable();
            HasMany(x => x.Payments).Cascade.All();
            HasMany(x => x.RequiredPayments).Cascade.All();
            Component(x => x.CurrentAddress);
        }
    }
}

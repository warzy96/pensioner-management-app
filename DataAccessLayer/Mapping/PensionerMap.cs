﻿using FluentNHibernate.Mapping;
using Model;

namespace DataAccessLayer.Mapping
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
            HasMany(x => x.Payments).Inverse().Cascade.AllDeleteOrphan();
            HasMany(x => x.RequiredPayments).Inverse().Cascade.AllDeleteOrphan();
            Component(x => x.CurrentAddress);
        }
    }
}

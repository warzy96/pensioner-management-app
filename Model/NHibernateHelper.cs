using System.Collections.Generic;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Model.Mapping;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;

namespace Model
{
    internal class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static Configuration _configuration;
        private static HbmMapping _mapping;

        public static ISession OpenSession()
        {
            //Open and return the nhibernate session
            return SessionFactory.OpenSession();
        }

        public static ISessionFactory SessionFactory => _sessionFactory ?? (_sessionFactory = Configuration.BuildSessionFactory());

        public static Configuration Configuration => _configuration ?? (_configuration = CreateConfiguration());

        public static HbmMapping Mapping => _mapping ?? (_mapping = CreateMapping());

        private static Configuration CreateConfiguration()
        {
            var configuration = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                    .UsingFile("pensionerDatabase.db"))
                .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<Pensioner>())
                .BuildConfiguration();

            var schemaExport = new SchemaExport(configuration);
            schemaExport.Create(false, true);

            return configuration;
        }

        private static HbmMapping CreateMapping()
        {
            var mapper = new ModelMapper();
            //Add the person mapping to the model mapper
            mapper.AddMappings(new List<System.Type> { typeof(PensionerMap) });
            //Create and return a HbmMapping of the model mapping in code
            return mapper.CompileMappingForAllExplicitlyAddedEntities();
        }
}
}

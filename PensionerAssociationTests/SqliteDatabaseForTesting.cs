using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Mapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace PensionerAssociationTests
{
    public class SqliteDatabaseForTesting : IDisposable
    {
        protected Configuration config;
        public ISessionFactory sessionFactory;
        public SqliteDatabaseForTesting()
        {
            var fluentConfig = Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.UsingFile("TestDB.db")
                    .ShowSql().FormatSql())
                    .Mappings(mapper =>
                    {
                        mapper.FluentMappings.AddFromAssemblyOf<PensionerMap>();
                    });

            var nhConfiguration = fluentConfig.BuildConfiguration();
            sessionFactory = nhConfiguration.BuildSessionFactory();

            using (var session = Session)
            {
                using (var tx = session.BeginTransaction())
                {
                    new SchemaExport(nhConfiguration).Execute(useStdOut: true,
                        execute: true,
                        justDrop: false,
                        connection: session.Connection,
                        exportOutput: Console.Out);
                    tx.Commit();
                }
            }
        }

        public ISession Session => sessionFactory.OpenSession();
        public void Dispose()
        {
            Session.Dispose();
            sessionFactory.Dispose();
        }
    }
}

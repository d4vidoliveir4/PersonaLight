using Biblioteca.Auxiliares;
using Data.Mapeamento.ClassesPai;
using Dominio.Entidades.ClassesPai;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.IO;

namespace Data.NHibernate
{
    public static class FluentNHibernateHelper
    {
        public static ISession OpenSession()
        {
            string connectionString = Criptografia.DecryptString(File.ReadAllText(@"ban"));           

            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(connectionString).ShowSql()
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Map<Entidade>>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg)
                .Execute(false, true))
                .BuildSessionFactory();

            return sessionFactory.OpenSession();

        }

    }
}

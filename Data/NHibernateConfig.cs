using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

public class NHibernateConfig
{
    private static readonly ISessionFactory _sessionFactory;

    static NHibernateConfig() => _sessionFactory = FluentConfigure();

    public static ISession GetCurrentSession() => _sessionFactory.OpenSession();

    public static void CloseSession() => _sessionFactory.Close();

    public static void CloseSessionFactory()
    {
        if (_sessionFactory != null)
        {
            _sessionFactory.Close();
        }
    }

    public static ISessionFactory FluentConfigure() => 
        Fluently.Configure()
            .Database(
                MsSqlConfiguration.MsSql2012
                    .ConnectionString(
                        cs =>
                        {
                            cs.Server("localhost");
                            cs.Username("sa");
                            cs.Password("fpw");
                            cs.Database("SD");
                        })
                    )
            .Cache(
                c => c.UseQueryCache()
                    .UseSecondLevelCache()
                    .ProviderClass<NHibernate.Cache.HashtableCacheProvider>())
            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .BuildSessionFactory();
}
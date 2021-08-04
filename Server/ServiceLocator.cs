using Logic.Assignatures.DTO;
using Logic.Assignatures.Interface;
using Logic.Implemenations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    /// <summary>
    /// Class to provides many instances of services.
    /// </summary>
    using Locator = Dictionary<Object, Object>;
    public static class ServiceLocator
    {
        private static Locator services = new Locator();

        private static void InitServices() =>
            services.AddScoped<IMaioridade, Maioridade>();

        public static T UseService<T>()
        {
            if (services.IsNotInitiated())
            {
                InitServices();
            }

            return (T)services[typeof(T)];
        }

        private static Locator AddScoped<T, TT>(this Locator services)
        {
            services
                .Add(typeof(T), (T)Activator.CreateInstance(typeof(TT)));
            
            return services;
        }

        private static bool IsNotInitiated(this Locator services) => services.Count == 0;
    }
}

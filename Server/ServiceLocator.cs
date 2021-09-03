using Logic;
using Logic.Assignatures.Interface;
using Logic.Implemenations;
using Logic.Implementations;
using System;
using System.Collections.Generic;

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
            services.AddScoped<IBaralho, Baralho>()
                    .AddScoped<IMaioridade, Maioridade>()
                    .AddScoped<IMedia, Media>()
                    .AddScoped<INatacao, Natacao>()
                    .AddScoped<IPeso, Peso>()
                    .AddScoped<IReajuste, Reajuste>()
                    .AddScoped<ISalario, Salario>()
                    .AddScoped<ISaldoMedio, SaldoMedio>();

        public static T UseService<T>()
        {
            if (services.IsNotInitiated())
            {
                InitServices();
            }

            return (T)services[typeof(T)];
        }

        private static Locator AddScoped<T, TT>(this Locator services) => 
            services.Apply(x => x.Add(typeof(T), (T)Activator.CreateInstance(typeof(TT))));

        private static bool IsNotInitiated(this Locator services) => services.Count == 0;
    }
}

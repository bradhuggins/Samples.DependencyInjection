#region Using Statements
using Autofac;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.Autofac
{
    /// <summary>
    /// Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static IContainer GetContainer()
        {
            // Create container and register types
            var builder = new ContainerBuilder();
            IContainer container = builder.Build();

            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static IContainer GetFluentContainer()
        {
            // Create container and register types
            var builder = new ContainerBuilder();

            //setup default object
            builder.RegisterType<ServiceConcrete2>().As<IService>();

            //register named type for fulltime service
            builder.RegisterType<ServiceConcrete2>().Named<IService>("ServiceConcrete1");

            //register named type for contract service
            builder.RegisterType<ServiceConcrete1>().Named<IService>("ServiceConcrete2");

            builder.RegisterType<ClientConstructor>().As<ClientConstructor>();

            //register for property injection
            builder.RegisterType<ClientProperty>().As<ClientProperty>().PropertiesAutowired();

            //register for method injection
            builder.RegisterType<ClientMethod>().As<ClientMethod>().PropertiesAutowired();

            IContainer container = builder.Build();

            return container;
        }

    }
}

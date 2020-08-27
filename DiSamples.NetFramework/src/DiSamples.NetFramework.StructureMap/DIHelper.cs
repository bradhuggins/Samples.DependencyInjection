#region Using Statement
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using StructureMap;
#endregion

namespace DiSamples.NetFramework.StructureMap
{
    /// <summary>
    /// Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static Container GetContainer()
        {
            // Create container and register types
            Container container = new Container();

            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static Container GetFluentContainer()
        {
            // Create container and register types
            Container container = new Container( c =>
            {
                //setup default object
                c.For<IService>().Use<ServiceConcrete2>();

                //register named type for fulltime service
                c.For<IService>().Add<ServiceConcrete2>().Named("ServiceConcrete1").HasExplicitName();

                //register named type for contract service
                c.For<IService>().Add<ServiceConcrete1>().Named("ServiceConcrete2").HasExplicitName();

                //register for property injection

                //register for method injection
                c.For<ClientMethod>().Use<ClientMethod>()
                .OnCreation((d, o) => o.DoWork(d.GetInstance<IService>()));

            });
            return container;
        }

    }
}

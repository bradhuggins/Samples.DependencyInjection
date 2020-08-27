#region Using Statements
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
{
    /// <summary>
    ///  Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static IWindsorContainer GetContainer()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer(new XmlInterpreter());    
     
            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static IWindsorContainer GetFluentContainer()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer();

            //setup default object
            container.Register(
                Component.For<IService>().ImplementedBy<ServiceConcrete2>()
                );

            //register named type for fulltime service
            container.Register(
                Component.For<IService>().ImplementedBy<ServiceConcrete2>().Named("ServiceConcrete1")
                );

            //register named type for contract service
            container.Register(
                Component.For<IService>().ImplementedBy<ServiceConcrete1>().Named("ServiceConcrete2")
                );

            container.Register(
                Component.For<ClientConstructor>().Named("ClientConstructor")
            );

            //register for property injection
            container.Register(
                Component.For<ClientProperty>().Named("ClientProperty")
            );

            //register for method injection
            container.Register(
                Component.For<ClientMethod>().Named("ClientMethod")
            );

            return container;
        }

    }
}

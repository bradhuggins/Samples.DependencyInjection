#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Microsoft.Practices.Unity.Configuration;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    /// <summary>
    /// Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static IUnityContainer GetContainer()
        {
            // Create container and register types
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();
            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static IUnityContainer GetFluentContainer()
        {
            // Create container and register types
            IUnityContainer container = new UnityContainer();

            //setup default object
            container.RegisterType<IService, ServiceConcrete2>();

            //register named type for service
            container.RegisterType<IService, ServiceConcrete2>("ServiceConcrete1");

            //register named type for service
            container.RegisterType<IService, ServiceConcrete1>("ServiceConcrete2");

            //register for property injection

            //register for method injection


            return container;
        }

    }
}

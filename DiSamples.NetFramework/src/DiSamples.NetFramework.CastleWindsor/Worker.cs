#region Using Statements
using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
{
    public class Worker
    {
        
        public ClientConstructor GetClientConstructor()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer();
            container.Register(
                Component.For<ClientConstructor>().Named("ClientConstructor"),
                Component.For<IService>().ImplementedBy<ServiceConcrete2>()
            );

            ClientConstructor toReturn = container.Resolve<ClientConstructor>();
            return toReturn;
        }

        public ClientProperty GetClientProperty()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer();
            container.Register(
                Component.For<ClientProperty>().Named("ClientProperty"),
                Component.For<IService>().ImplementedBy<ServiceConcrete2>()
            );

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("Service", new ServiceConcrete2());

            ClientProperty toReturn = container.Resolve<ClientProperty>(properties);
            return toReturn;
        }

        public ClientMethod GetClientMethod()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer();
            container.Register(
                Component.For<ClientMethod>().Named("ClientMethod"),
                Component.For<IService>().ImplementedBy<ServiceConcrete2>()
            );

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("Service", new ServiceConcrete2());

            ClientMethod toReturn = container.Resolve<ClientMethod>(properties);
            return toReturn;
        }


    }
}

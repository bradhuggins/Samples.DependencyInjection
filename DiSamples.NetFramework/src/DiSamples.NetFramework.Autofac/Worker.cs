#region Using Statements
using System.Collections.Generic;
using Autofac;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.Autofac
{
    public class Worker
    {       
        public ClientConstructor GetClientConstructor()
        {
            // Create container and register types
            var builder = new ContainerBuilder();
            builder.RegisterType<ClientConstructor>().As<ClientConstructor>();
            builder.RegisterType<ServiceConcrete1>().As<IService>();
            IContainer container = builder.Build();
                        
            ClientConstructor toReturn = container.Resolve<ClientConstructor>();

            return toReturn;
        }

        public ClientProperty GetClientProperty()
        {
            // Create container and register types
            var builder = new ContainerBuilder();
            builder.RegisterType<ClientProperty>().As<ClientProperty>().PropertiesAutowired();
            builder.RegisterType<ServiceConcrete1>().As<IService>();
            IContainer container = builder.Build();

            ClientProperty toReturn = container.Resolve<ClientProperty>();
            return toReturn;
        }

        public ClientMethod GetClientMethod()
        {
            // Create container and register types
            var builder = new ContainerBuilder();
            builder.RegisterType<ClientMethod>().As<ClientMethod>().PropertiesAutowired();
            builder.RegisterType<ServiceConcrete1>().As<IService>();
            IContainer container = builder.Build();

            ClientMethod toReturn = container.Resolve<ClientMethod>();
            return toReturn;
        }

    }
}

#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Ninject;
#endregion

namespace DiSamples.NetFramework.Ninject
{
    public class Worker
    {        
        public ClientConstructor GetClientConstructor()
        {
            // Create container and register types
            IKernel container = DIHelper.GetFluentContainer();

            ClientConstructor toReturn = container.Get<ClientConstructor>();
            
            return toReturn;

        }

        public ClientProperty GetClientProperty()
        {
            // Create container and register types
            IKernel container = DIHelper.GetFluentContainer();

            ClientProperty toReturn = container.Get<ClientProperty>();
            return toReturn;
        }

        public ClientMethod GetClientMethod()
        {
            // Create container and register types
            IKernel container = DIHelper.GetFluentContainer();

            ClientMethod toReturn = container.Get<ClientMethod>();
            return toReturn;
        }

    }
}

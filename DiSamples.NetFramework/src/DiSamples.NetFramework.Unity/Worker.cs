#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    public class Worker
    {       
        public ClientConstructor GetClientConstructor()
        {
            // Create container and register types
            IUnityContainer container = DIHelper.GetFluentContainer();

            ClientConstructor toReturn = container.Resolve<ClientConstructor>();

            return toReturn;
        }

        public ClientProperty GetClientProperty()
        {
            // Create container and register types
            IUnityContainer container = DIHelper.GetFluentContainer();

            ClientProperty toReturn = container.Resolve<ClientProperty>();
            return toReturn;
        }

        public ClientMethod GetClientMethod()
        {
            // Create container and register types
            IUnityContainer container = DIHelper.GetFluentContainer();

            ClientMethod toReturn = container.Resolve<ClientMethod>();
            return toReturn;
        }
        
    }
}

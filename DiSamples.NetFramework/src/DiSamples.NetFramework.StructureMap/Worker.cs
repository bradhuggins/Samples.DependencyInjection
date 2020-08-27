#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using StructureMap;
#endregion

namespace DiSamples.NetFramework.StructureMap
{
    public class Worker
    {       
        public ClientConstructor GetClientConstructor()
        {
            // Create container and register types
            Container container = DIHelper.GetFluentContainer();
            
            ClientConstructor toReturn = container.GetInstance<ClientConstructor>();

            return toReturn;
        }

        public ClientProperty GetClientProperty()
        {
            // Create container and register types
            Container container = DIHelper.GetFluentContainer();

            ClientProperty toReturn = container.GetInstance<ClientProperty>();
            return toReturn;

        }

        public ClientMethod GetClientMethod()
        {
            // Create container and register types
            Container container = DIHelper.GetFluentContainer();

            ClientMethod toReturn = container.GetInstance<ClientMethod>();
            return toReturn;
        }


    }
}

#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Ninject;
#endregion

namespace DiSamples.NetFramework.Ninject
{
    public class ClientMethod
    {
        public IService Service { get; set; }

        [Inject]
        public void DoWork([Named("ServiceConcrete1")] IService service)
        {
            this.Service = service;
        } 
        
    }
}

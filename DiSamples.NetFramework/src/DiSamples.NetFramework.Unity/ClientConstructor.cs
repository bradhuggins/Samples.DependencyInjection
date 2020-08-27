#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    public class ClientConstructor
    {
        public IService Service { get; set; }

        [InjectionConstructor]
        public ClientConstructor(IService service)
        {
            this.Service = service;
        } 
        
    }
}

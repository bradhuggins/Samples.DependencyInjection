#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    public class ClientMethod
    {
        public IService Service { get; set; }

        [InjectionMethod]
        public void DoWork(IService service)
        {
            this.Service = service;
        } 

    }    
}

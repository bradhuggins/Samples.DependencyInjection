#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
{
    public class ClientMethod
    {
        public IService Service { get; set; }

        public void DoWork(IService service)
        {
            this.Service = service;
        } 
                
    }
}

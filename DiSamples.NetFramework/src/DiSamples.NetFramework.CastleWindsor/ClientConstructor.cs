#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
{
    public class ClientConstructor
    {
        public IService Service { get; set; }

        public ClientConstructor(IService service)
        {
            this.Service = service;
        } 
        
    }
}

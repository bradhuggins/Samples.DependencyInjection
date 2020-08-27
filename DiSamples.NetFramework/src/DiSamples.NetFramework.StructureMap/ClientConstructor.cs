#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using StructureMap;
#endregion

namespace DiSamples.NetFramework.StructureMap
{
    public class ClientConstructor
    {
        public IService Service { get; set; }

        [DefaultConstructor]
        public ClientConstructor(IService service)
        {
            this.Service = service;
        } 
        
    }
}

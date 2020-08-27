#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using StructureMap.Attributes;
#endregion

namespace DiSamples.NetFramework.StructureMap
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

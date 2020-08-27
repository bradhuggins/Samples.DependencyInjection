#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using StructureMap.Attributes;
#endregion

namespace DiSamples.NetFramework.StructureMap
{
    public class ClientProperty
    {
        [SetterProperty]
        public IService Service { get; set; }

    }
}

#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    public class ClientProperty
    {       
        [Dependency]
        public IService Service { get; set; }

    }
}

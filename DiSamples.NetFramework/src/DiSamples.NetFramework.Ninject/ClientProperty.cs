#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using Ninject;
#endregion

namespace DiSamples.NetFramework.Ninject
{
    public class ClientProperty
    {
        [Inject, Named("ServiceConcrete1")]
        public IService Service { get; set; }

    }


}

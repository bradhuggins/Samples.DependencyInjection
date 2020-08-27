#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
#endregion

namespace DiSamples.NetFramework.Domain.Models
{
    public class ServiceConcrete2 : IService
    {
        public string GetData()
        {
            return "Message from Concrete2";
        }

    }

}

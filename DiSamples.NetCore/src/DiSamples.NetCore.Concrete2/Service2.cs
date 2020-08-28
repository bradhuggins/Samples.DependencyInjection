using DiSamples.NetCore.Interfaces;
using System;

namespace DiSamples.NetCore.Concrete2
{
    public class Service2 : IService
    {
        public string GetData()
        {
            return "Message from Service2 @ " + DateTime.Now.ToString();
        }
    }
}

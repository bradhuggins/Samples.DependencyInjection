using DiSamples.NetCore.Interfaces;
using System;

namespace DiSamples.NetCore.Concrete1
{
    public class Service1 : IService
    {
        public string GetData()
        {
            return "Message from Service1";
        }
    }
}

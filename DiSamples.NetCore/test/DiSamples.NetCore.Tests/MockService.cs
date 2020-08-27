using DiSamples.NetCore.Interfaces;
using System;

namespace DiSamples.NetCore.Tests
{
    public class MockService : IService
    {
        public string GetData()
        {
            return "Message from MockService";
        }
    }
}

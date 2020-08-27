#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using System;
#endregion

namespace DiSamples.NetFramework.Autofac
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

#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using System;
using System.Runtime.InteropServices;
#endregion

namespace DiSamples.NetFramework.Autofac
{
    public class ClientConstructor
    {
        public IService Service { get; set; }

        public ClientConstructor(IService service)
        {
            this.Service = service;
        }

    }
}

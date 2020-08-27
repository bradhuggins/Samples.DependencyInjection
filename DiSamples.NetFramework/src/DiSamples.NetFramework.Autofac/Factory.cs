﻿#region Using Statements
using Autofac;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.Autofac
{
    /// <summary>
    /// Factory pattern class - Automatic Factories in Autofac 2
    /// </summary>
    public static class Factory
    {
        #region Methods

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <returns>An object that implements the IService interface</returns>
        public static IService CreateInstance()
        {
            // Create container and register types
            IContainer container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IService obj = container.Resolve<IService>();
            return obj;
        }
        
        /// <summary>
        /// Creates a named instance.
        /// </summary>
        /// <returns>An object that implements the IService interface</returns>
        public static IService CreateInstanceWithName(string name)
        {
            // Create container and register types
            IContainer container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IService obj = container.ResolveNamed<IService>(name);
            return obj;
        }
        
        #endregion

    }
}

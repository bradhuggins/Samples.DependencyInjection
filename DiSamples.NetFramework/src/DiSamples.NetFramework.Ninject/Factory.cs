#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Ninject;
#endregion

namespace DiSamples.NetFramework.Ninject
{
    /// <summary>
    /// Factory pattern class - Automatic Factories in Ninject
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
            IKernel container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IService obj = container.Get<IService>(m => m.Name == null);
            return obj;
        }


        /// <summary>
        /// Creates a named instance.
        /// </summary>
        /// <returns>An object that implements the IService interface</returns>
        public static IService CreateInstanceWithName(string name)
        {
            // Create container and register types
            IKernel container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IService obj = container.Get<IService>(name);
            return obj;
        }
        
        #endregion

    }
}

#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    /// <summary>
    /// Factory pattern class - Automatic Factories in Unity 2
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
            IUnityContainer container = DIHelper.GetFluentContainer();
            
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
            IUnityContainer container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IService obj = container.Resolve<IService>(name);
            return obj;
        }
        
        #endregion

    }
}

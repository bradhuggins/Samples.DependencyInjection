#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using StructureMap;
#endregion

namespace DiSamples.NetFramework.StructureMap
{
    /// <summary>
    /// Factory pattern class - Automatic Factories in StructureMap
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
            Container container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IService obj = container.GetInstance<IService>();
            return obj;
        }

        /// <summary>
        /// Creates a named instance.
        /// </summary>
        /// <returns>An object that implements the IService interface</returns>
        public static IService CreateInstanceWithName(string name)
        {
            // Create container and register types
            Container container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IService obj = container.GetInstance<IService>(name);
            return obj;
        }
        
        #endregion

    }
}

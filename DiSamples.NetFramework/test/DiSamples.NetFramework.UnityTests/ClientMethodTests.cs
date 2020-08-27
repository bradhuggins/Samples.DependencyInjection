#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
#endregion

namespace DiSamples.NetFramework.UnityTests
{
    /// <summary>
    /// Used to test the TimeTracker class
    /// </summary>
    [TestClass]
    public class ClientMethodTests
    {
        [TestMethod()]
        public void MethodTestFluent()
        {
            //Arrange
            ServiceConcrete1 expected = new ServiceConcrete1();
            var container = DIHelper.GetContainer();

            //Act
            ClientMethod actual = container.Resolve<ClientMethod>();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.Service.GetType());
        }


    }
}

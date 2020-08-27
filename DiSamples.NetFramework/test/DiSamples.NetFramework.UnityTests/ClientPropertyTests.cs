#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
#endregion

namespace DiSamples.NetFramework.UnityTests
{
    [TestClass]
    public class ClientPropertyTests
    {
        [TestMethod()]
        public void PropertyTestFluent()
        {
            //Arrange
            ServiceConcrete1 expected = new ServiceConcrete1();
            var container = DIHelper.GetContainer();

            //Act
            ClientProperty actual = container.Resolve<ClientProperty>();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.Service.GetType());
        }

    }
}

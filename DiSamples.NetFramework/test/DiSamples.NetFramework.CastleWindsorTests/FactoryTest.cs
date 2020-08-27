#region Using Statements
using DiSamples.NetFramework.CastleWindsor;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace DiSamples.NetFramework.CastleWindsorTests
{
    /// <summary>
    ///This is a test class for FactoryTest and is intended
    ///to contain all FactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FactoryTest
    {
        #region Test Methods

        /// <summary>
        ///A test for CreateInstance
        ///</summary>
        [TestMethod()]
        public void CreateInstanceTest()
        {
            //Arrange
            ServiceConcrete2 expected = new ServiceConcrete2();
            IService actual;

            //Act
            actual = Factory.CreateInstance();

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        /// <summary>
        ///A test for CreateInstanceWithName
        ///</summary>
        [TestMethod()]
        public void CreateInstanceWithNameTest()
        {
            //Arrange
            ServiceConcrete1 expected = new ServiceConcrete1();
            IService actual;

            //Act
            actual = Factory.CreateInstanceWithName("ServiceConcrete2");

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        #endregion

    }
}

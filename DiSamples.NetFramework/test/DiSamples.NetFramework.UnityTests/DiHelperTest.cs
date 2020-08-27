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
    ///This is a test class for DiHelper and is intended
    ///to contain all DiHelper Unit Tests
    ///</summary>
    [TestClass()]
    public class DiHelperTest
    {
        #region Test Methods

        [TestMethod()]
        public void GetContainerTest()
        {
            //Arrange
            ServiceConcrete1 expected = new ServiceConcrete1();
            var container = DIHelper.GetContainer();

            //Act
            IService actual = container.Resolve<IService>();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void GetContainerNamedTest()
        {
            //Arrange
            ServiceConcrete1 expected = new ServiceConcrete1();
            var container = DIHelper.GetContainer();

            //Act
            IService actual = container.Resolve<IService>("ServiceConcrete1");

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void GetFluentContainerTest()
        {
            //Arrange
            ServiceConcrete2 expected = new ServiceConcrete2();
            var container = DIHelper.GetFluentContainer();

            //Act
            IService actual = container.Resolve<IService>();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void GetFluentContainerNamedTest()
        {
            //Arrange
            ServiceConcrete1 expected = new ServiceConcrete1();
            var container = DIHelper.GetFluentContainer();

            //Act
            IService actual = container.Resolve<IService>("ServiceConcrete2");

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        #endregion

    }
}

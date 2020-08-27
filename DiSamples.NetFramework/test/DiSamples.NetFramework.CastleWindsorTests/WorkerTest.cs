#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.CastleWindsor;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace DiSamples.NetFramework.CastleWindsorTests
{
    /// <summary>
    ///This is a test class for WorkerTest and is intended
    ///to contain all WorkerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WorkerTest
    {
        #region Test Methods

        /// <summary>
        ///A test for GetClientConstructor
        ///</summary>
        [TestMethod()]
        public void GetClientConstructorTest()
        {
            //Arrange
            Worker target = new Worker();

            //Act
            ClientConstructor actual = target.GetClientConstructor();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(ServiceConcrete2), actual.Service.GetType());
        }
        
        /// <summary>
        ///A test for GetClientProperty
        ///</summary>
        [TestMethod()]
        public void GetClientPropertyTest()
        {
            //Arrange
            Worker target = new Worker();

            //Act
            ClientProperty actual = target.GetClientProperty();

            //Assert
            Assert.AreEqual(typeof(ServiceConcrete2), actual.Service.GetType());
        }

        /// <summary>
        ///A test for GetClientMethod
        ///</summary>
        [TestMethod()]
        public void GetClientMethodTest()
        {
            //Arrange
            Worker target = new Worker();

            //Act
            ClientMethod actual = target.GetClientMethod();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(ServiceConcrete2), actual.Service.GetType());
        }


        #endregion

    }
}

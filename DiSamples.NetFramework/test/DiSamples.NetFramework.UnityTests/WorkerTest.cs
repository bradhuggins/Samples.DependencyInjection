#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace DiSamples.NetFramework.UnityTests
{
    /// <summary>
    ///This is a test class for WorkerTest and is intended
    ///to contain all WorkerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WorkerTest
    { 
        [TestMethod()]
        public void GetClientConstructorTest()
        {
            //Arrange
            Worker target = new Worker();
            ClientConstructor actual = target.GetClientConstructor();

            //Act

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(ServiceConcrete2), actual.Service.GetType());
        }

        [TestMethod()]
        public void GetClientPropertyTest()
        {
            //Arrange
            Worker target = new Worker();
            ClientProperty actual = target.GetClientProperty();

            //Act

            //Assert
            Assert.AreEqual(typeof(ServiceConcrete2), actual.Service.GetType());
        } 

        [TestMethod()]
        public void GetClientMethodTest()
        {
            //Arrange
            Worker target = new Worker();
            ClientMethod actual = target.GetClientMethod();

            //Act

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(ServiceConcrete2), actual.Service.GetType());
        }

    }
}

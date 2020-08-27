using DiSamples.NetCore.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiSamples.NetCore.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void GetService1Test()
        {
            // Arrange
            Concrete1.Service1 service = new Concrete1.Service1();
            HomeController target = new HomeController(service);

            // Act
            var actual = target.Get() as OkObjectResult;

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void GetService2Test()
        {
            // Arrange
            Concrete2.Service2 service = new Concrete2.Service2();
            HomeController target = new HomeController(service);

            // Act
            var actual = target.Get() as OkObjectResult;

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void GetMockServiceTest()
        {
            // Arrange
            MockService service = new MockService();
            HomeController target = new HomeController(service);

            // Act
            var actual = target.Get() as OkObjectResult;

            // Assert
            Assert.IsNotNull(actual);
        }



    }
}

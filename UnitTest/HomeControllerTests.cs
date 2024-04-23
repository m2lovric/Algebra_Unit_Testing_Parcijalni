using aspnet_core_unit_1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace UnitTest
{
    public class HomeControllerTests
    {
        private Mock<ILogger<HomeController>> _logger = new Mock<ILogger<HomeController>>();

        [Fact]
        public void CheckCountValueTest_2_ViewResult()
        {
            var controller = new HomeController(_logger.Object);
            int value = 2;

            var result = controller.CheckCountValue(value);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void CheckCountValueTest_500_Exception()
        {
            var controller = new HomeController(_logger.Object);
            int value = 500;
            
            Assert.Throws<Exception>(() => controller.CheckCountValue(value));
        }
    }
}
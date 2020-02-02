using ai_betterbet.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace ai_betterbet_tests
{
    public class HomeControllerTests : IDisposable
    {
        private readonly HomeController homeController;

        //setup
        /// <summary>
        /// xunit will create new test class for every test in class
        /// so setUp and clean is not necessary here but it presents use-case
        /// </summary>
        public HomeControllerTests()
        {
            homeController = new HomeController();
        }

        //clean
        public void Dispose()
        {
            homeController.Dispose();
        }

        [Fact]
        public void Index_Returns_ViewResult()
        {
            //arrange
            //act
            var result = homeController.Index();
            //assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Test_Returns_ViewResult()
        {
            //arrange
            //act
            var result = homeController.Tests();
            //assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Ping_Returns_Healtcheck_Default_Message()
        {
            //arrange
            string defaultMessage = HomeController.MESSAGE_HEALTHY;
            //act
            var result = homeController.Ping();
            //assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal(contentResult.Content, defaultMessage);
        }

        [Fact]
        public void Healtcheck_Returns_ContentResult_And_Response_From_Message()
        {
            //arrange
            const string message = "Foo";
            //act
            var result = homeController.Healtcheck(message);
            //assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal(contentResult.Content, message);
        }

        [Fact]
        public void Healtcheck_Returns_Default_Message_When_Run_Without_Parameters()
        {
            //arrange
            string defaultMessage = HomeController.MESSAGE_HEALTHY;
            var result = homeController.Healtcheck();
            //assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal(contentResult.Content, defaultMessage);
        }
    }
}
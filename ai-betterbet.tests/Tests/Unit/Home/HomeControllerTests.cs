using ai_betterbet.Controllers;
using ai_betterbet.Model;
using ai_betterbet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace ai_betterbet_tests
{
    public class HomeControllerTests : IDisposable
    {
        private readonly HomeController homeController;

        private readonly List<Team> testTeamsList;

        //setup
        /// <summary>
        /// xunit will create new test class for every test in class
        /// so setUp and clean is not necessary here but it presents use-case
        /// </summary>
        public HomeControllerTests()
        {
            //Given:
            //arrange dependencies
            testTeamsList = new List<Team> { new Team(1, "Valencia FC", "Primera Division", 200.0m) };
            var mockTeamRepo = new Mock<IRepository<Team>>();
            mockTeamRepo.Setup(repo => repo.GetAll())
                .Returns(testTeamsList);
            homeController = new HomeController(mockTeamRepo.Object);
        }

        //clean
        public void Dispose()
        {
            homeController.Dispose();
        }

        [Fact]
        public void Index_Returns_ViewResult_WithAList_OfTeams()
        {
            //Given: HomeController dependency is set testTeamList
            //arrange - see Constructor
            //When: Index method is called and View retured
            //act
            var result = homeController.Index();
            //Then:
            //assert
            //View is of ViewResult type
            var viewResult = Assert.IsType<ViewResult>(result);
            //And Data available for View as Model is of List<Team> type or derived
            var viewModel = Assert.IsAssignableFrom<List<Team>>(viewResult.ViewData.Model);
            //And List is of size testTeamList.Count
            Assert.Equal(testTeamsList.Count, viewModel.Count);
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
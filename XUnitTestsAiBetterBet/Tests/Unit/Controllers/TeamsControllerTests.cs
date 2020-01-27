using ai_betterbet.Controllers;
using System;
using Xunit;

namespace XUnitTestsAiBetterBet
{
    public class TeamsControllerTests
    {
        [Fact]
        public void IsMessageReturnedToBeImplemented()
        {
            //arrange
            TeamsController teamsController = new TeamsController();
            const string ToBeImplementedMessage = "To be implemented yet";
            //act
            String message = teamsController.CreateTeam();
            //assert
            Assert.Equal(ToBeImplementedMessage, message);
        }
    }
}
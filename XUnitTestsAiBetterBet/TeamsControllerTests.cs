using System;
using Xunit;
using ai_betterbet.Controllers;
namespace XUnitTestsAiBetterBet
{
    public class TeamsControllerTests
    {
 
        [Fact]
        public void IsMessageReturnedToBeImplemented()
        {
            //arrange
            TeamsController c = new TeamsController();
            const string ToBeImplementedMessage = "To be implemented yet";
            //act
            String message = c.createTeam();
            //assert
            Assert.Equal(ToBeImplementedMessage, message);
        }
    }
}

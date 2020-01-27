using ai_betterbet.Controllers;
using System;
using Xunit;

namespace XUnitTestsAiBetterBet
{
    public class MessagesControllerTests
    {
        [Fact]
        public void MessageContainsGithubURL()
        {
            //arrange
            MessagesController messagesController = new MessagesController();
            const string githubURL = "https://github.com";
            //act
            string message = messagesController.GetMessages();
            //assert
            Assert.Contains(githubURL, message);
        }
    }
}
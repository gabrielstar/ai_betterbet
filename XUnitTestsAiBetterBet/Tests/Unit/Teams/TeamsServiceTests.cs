using ai_betterbet.Services;
using Xunit;
using Moq;
using System;
using ai_betterbet.Model;
using System.Collections.Generic;

namespace XUnitTestsAiBetterBet
{
    public class TeamsServiceTests
    {
        private readonly TeamsService teamsService;
        private readonly List<Team> teams = new List<Team>();
        Mock<IFinancialService> financialServiceMock = new Mock<IFinancialService>();

        public TeamsServiceTests()
        {
            teams.Add(new Team(1,"1","1",1));
            financialServiceMock.Setup(f=>f.GetRichTeams(teams)).Returns(new List<Team>());
            teamsService = new TeamsService(financialServiceMock.Object);
        }
        [Fact]
        public void Get_Rich_Teams_Budget_Should_Return_0_For_Poor_Teams()
        {
            Assert.Equal(0,teamsService.GetRichTeamsBudget(teams));
        }
    }
}
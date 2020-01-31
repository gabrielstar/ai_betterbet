using ai_betterbet.Model;
using ai_betterbet.Services;
using Moq;
using System.Collections.Generic;
using Xunit;
using static ai_betterbet.Services.FinancialService;

namespace XUnitTestsAiBetterBet
{
    public class TeamsServiceTests
    {
        public class TeamsServiceTestsEmptyListRichTeams
        {
            private readonly TeamsService teamsService;
            private readonly List<Team> teams = new List<Team>();
            private readonly Mock<IFinancialService> financialServiceMock = new Mock<IFinancialService>();

            public TeamsServiceTestsEmptyListRichTeams()
            {
                teams.Add(new Team(1, "Valencia", "1", 1));
                financialServiceMock.Setup(f => f.GetRichTeams(teams)).Returns(new List<Team>());
                teamsService = new TeamsService(financialServiceMock.Object);
            }

            [Fact]
            public void Get_Rich_Teams_Budget_Should_Return_0_For_Poor_Teams()
            {
                Assert.Equal(0, teamsService.GetRichTeamsBudget(teams));
            }
        }

        public class TeamsServiceTestsRichTeams
        {
            private readonly TeamsService teamsService;
            private readonly List<Team> teams = new List<Team>();
            private readonly Mock<IFinancialService> financialServiceMock = new Mock<IFinancialService>();

            public TeamsServiceTestsRichTeams()
            {
                teams.Add(new Team(1, "Valencia", "Primera Division", (decimal)FINANCIAL_LEVELS.RICH));
                teams.Add(new Team(2, "MU", "Premier League", (decimal)FINANCIAL_LEVELS.RICH));
                teams.Add(new Team(3, "Borussia D", "Bundesliga", (decimal)FINANCIAL_LEVELS.RICH));
                financialServiceMock.Setup(f => f.GetRichTeams(teams)).Returns(teams);
                teamsService = new TeamsService(financialServiceMock.Object);
            }

            [Fact]
            public void Get_Rich_Teams_Budget_Should_Return_Correct_Result()
            {
                Assert.Equal(3*(decimal)(FINANCIAL_LEVELS.RICH), teamsService.GetRichTeamsBudget(teams));
                financialServiceMock.Verify(mock=>mock.GetRichTeams(teams),Times.Once);
            }
        }
    }
}
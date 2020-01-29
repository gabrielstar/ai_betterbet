using ai_betterbet.Model;
using ai_betterbet.Repositories;
using System.Linq;
using Xunit;

namespace XUnitTestsAiBetterBet
{
    public class TeamsRepositoryTests
    {
        //This is "test class as context" pattern
        public class TeamsRepositoryTestsWithDefaultTeamsList
        {
            private readonly IRepository<Team> teamsRepository;
            private const int DEFAULT_TEAMS_NUMBER = 2;

            public TeamsRepositoryTestsWithDefaultTeamsList()
            {
                teamsRepository = new TeamsRepository();
            }

            [Fact]
            public void DefaultListOfTeamsHasDefaultTeamsNumber()
            {
                //arrange
                //act
                int count = teamsRepository.GetAll().Count();
                //assert
                Assert.Equal(DEFAULT_TEAMS_NUMBER, count);
            }
        }
        public class TeamsRepositoryTestsWithNonDefaultTeamsList
        {
            private readonly IRepository<Team> teamsRepository;

            public TeamsRepositoryTestsWithNonDefaultTeamsList()
            {
                teamsRepository = new TeamsRepository();
                teamsRepository.DeleteAll();
                
            }

            [Fact]
            public void ListOfTeamsHasZeroElements()
            {
                //arrange
                //act
                int count = teamsRepository.GetAll().Count();
                //assert
                Assert.Equal(0, count);
            }
            [Fact]
            public void ListOfTeamsHas1ElementAfterAddingOne()
            {
                //arrange
                teamsRepository.Create(new Team(1,"Team","League"));
                //act
                int count = teamsRepository.GetAll().Count();
                //assert
                Assert.Equal(1, count);
            }
        }
    }
}
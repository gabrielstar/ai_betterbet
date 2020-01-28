namespace ai_betterbet.Repositories
{
    public interface ITeamsRepository
    {
        string CreateTeam();
    }

    public class TeamsRepository : ITeamsRepository
    {
        private const string CREATED_MESSAGE = "created";

        public string CreateTeam() => CREATED_MESSAGE;
    }
}
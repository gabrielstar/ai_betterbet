using ai_betterbet.Model;
using System.Collections.Generic;

namespace ai_betterbet.Repositories
{
    public interface IRepository<T>
    {
        string Create();
        List<T> Get();
        List<T> GetByID(int ID);
    }

    public class TeamsRepository : IRepository<Team>
    {
        private static List<Team> teams = new List<Team>();
        private const string CREATED_MESSAGE = "created";

        public string Create() => CREATED_MESSAGE;

        public List<Team> Get()
        {
            return teams;
        }

        public List<Team> GetByID(int ID)
        {
            throw new System.NotImplementedException();
        }
    }
}
using ai_betterbet.Model;
using System.Collections.Generic;

namespace ai_betterbet.Repositories
{

    public class TeamsRepository : IRepository<Team>
    {
        private readonly List<Team> teams = new List<Team>();
        private const string CREATED_MESSAGE = "created";
        public TeamsRepository()
        {
            InitTeams();   
        }
        public string Create() => CREATED_MESSAGE;

        public string Create(Team element)
        {
            teams.Add(element);
            return CREATED_MESSAGE;
;        }

        public List<Team> GetAll()
        {
            return teams;
        }

        public List<Team> GetAllByID(int ID)
        {
            return teams;
        }

        private  void InitTeams()
        {
            teams.Add(new Team(1, "Real Madrid", "Primera Division", 100.0m));
            teams.Add(new Team(2, "FC Barcelona", "Primera Division",50.5m));
        }

        public void DeleteAll()
        {
            teams.Clear();
        }

    }
}
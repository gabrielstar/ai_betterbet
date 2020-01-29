using ai_betterbet.Model;
using System.Collections.Generic;

namespace ai_betterbet.Repositories
{
    public interface IRepository<T>
    {
        string Create();
        string Create(T element);
        List<T> GetAll();
        List<T> GetAllByID(int ID);
        void DeleteAll();
    }

    public class TeamsRepository : IRepository<Team>
    {
        private List<Team> teams = new List<Team>();
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
            throw new System.NotImplementedException();
        }

        private  void InitTeams()
        {
            teams.Add(new Team(1, "Real Madrid", "Primera Division"));
            teams.Add(new Team(2, "FC Barcelona", "Primera Division"));
        }

        public void DeleteAll()
        {
            teams.Clear();
        }

    }
}
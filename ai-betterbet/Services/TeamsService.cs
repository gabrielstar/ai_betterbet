using ai_betterbet.Model;
using ai_betterbet.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ai_betterbet.Services
{
    /// <summary>
    /// Service has all Repository methods plus new ones
    /// </summary>
    /// <typeparam name="Team"></typeparam>
    public interface ITeamsService<Team> : IRepository<Team>
    {
        int GetIDSum();

        decimal GetRichTeamsBudget(List<Team> teams);
    }

    /// <summary>
    /// Service is derived from repository classses to get Repository methos
    /// implements also own interface methods that has not been covered yet
    /// </summary>
    public class TeamsService : TeamsRepository, ITeamsService<Team>
    {
        private readonly IFinancialService financialService;

        public TeamsService(IFinancialService financialService)
        {
            this.financialService = financialService;
        }

        public int GetIDSum()
        {
            int sum = 0;
            try
            {
                sum = this.GetAll().Sum(x => x.ID);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot get sum due to " + e.Message);
            }
            return sum;
        }

        public decimal GetRichTeamsBudget(List<Team> teams)
        {
            return financialService.GetRichTeams(teams).Sum(team => team.Budget);
        }
    }
}
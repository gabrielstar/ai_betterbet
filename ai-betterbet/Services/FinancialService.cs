using ai_betterbet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ai_betterbet.Services
{
    public interface IFinancialService{
        List<Team> GetRichTeams(List<Team> teams);
    }

    public class FinancialService : IFinancialService
    {   
        /// <summary>
        /// in c# enum accepts only int :(
        /// so cast to decimal is risky
        /// </summary>
        public enum FINANCIAL_LEVELS{
            POOR = 20,
            RICH = 100
        }
        public List<Team> GetRichTeams(List<Team> teams)
        {
            return teams.Where(predicate: team => team.Budget >= (decimal)FINANCIAL_LEVELS.RICH).ToList();
        }
    }
}

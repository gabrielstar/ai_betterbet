namespace ai_betterbet.Controllers
{
    using ai_betterbet.Model;
    using ai_betterbet.Repositories;
    using ai_betterbet.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;

    /// <summary>
    /// Class provides entry point for Teams Management
    /// This class is an example of commenting code
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamsService<Team> _teamsService;

        public TeamsController(ITeamsService<Team> teamsService)
        {
            _teamsService = teamsService;
        }
        /// <summary>
        /// The GetTeams - searches for teams by name and country
        /// </summary>
        /// <param name="teamName">The teamName<see cref="string"/></param>
        /// <param name="country">The country<see cref="string"/></param>
        /// <returns>array of teams</returns>
        [HttpGet]
        [HttpGet("all")]
        [HttpGet("{teamName}/{country=Spain}")]
        public string[] GetTeams(string teamName, string country)
        {
            if (String.IsNullOrEmpty(teamName))
            {
                return new[]
                {
                 $"Country: {country}",
                "Real Madrid",
                "FC Barcelona"
                };
            }
            return ($"country:{country};" + teamName).Split(';');
        }

        /// <summary>
        /// The CreateTeam
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        [HttpPost]
        [HttpPost("createTeam")]
        public string CreateTeam() => _teamsService.Create();

        [HttpGet]
        [HttpPost("sum")]
        public int GetIDSum() => _teamsService.GetIDSum();
    }
}

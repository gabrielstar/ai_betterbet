namespace ai_betterbet.Controllers
{
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
        /// <summary>
        /// Method to search for teams
        /// </summary>
        /// <param name="teamName">Name of team</param>
        /// <param name="country">Country of team</param>
        /// <returns>Array of Teams</returns>
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
        /// Creates new team
        /// </summary>
        /// <returns>Message if team was created</returns>
        [HttpPost]
        [HttpPost("createTeam")]
        public string CreateTeam() => "To be implemented yet";
    }
}

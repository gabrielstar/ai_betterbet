using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Provides control action over Teams
 */
namespace ai_betterbet.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        //Routing examples
        [HttpGet]
        [HttpGet("all")]
        [HttpGet("{teamName}/{country=Spain}")]
        public string [] getTeams(string teamName, string country)
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
            return ($"country:{country};"+teamName).Split(';');
        }
        [HttpPost]
        [HttpPost("createTeam")]
        public string createTeam()
        {
            return "To be implemented yet";
        }

    }
}
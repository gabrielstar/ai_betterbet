using Microsoft.AspNetCore.Mvc;

/*
 * Provides control action over Teams
 */
namespace ai_betterbet.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        public string [] getTeams()
        {
            return new[]
            {
                "Real Madrid",
                "FC Barcelona"
            };
        }
    }
}
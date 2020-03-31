using ai_betterbet.Model;
using ai_betterbet.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ai_betterbet.Controllers
{
    /**
     * Main Controller
     **/

    public class HomeController : Controller
    {
        private readonly IRepository<Team> teamRepository;

        public HomeController(IRepository<Team> teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public static string MESSAGE_HEALTHY => "healthy";

        /**
* Main Entry Page
*/

        public IActionResult Index()
        {
            //making it more generic by using interface
            IEnumerable<Team> teams = teamRepository.GetAll();
            return View(teams);
        }

        /**
         * Displays information about tests for the project
         */

        [Route("Tests")]
        public IActionResult Tests()
        {
            return View("Tests");
        }

        /**
         * Endpoint for healthcheck from monitoring systems
         **/

        [Route("healthcheck")]
        [Route("home/healthcheck")]
        public IActionResult Healtcheck(string message = "")
        {
            if (string.IsNullOrEmpty(message))
            {
                message = MESSAGE_HEALTHY;
            }
            return Content(message);
        }

        /**
         * Alias to Healthcheck
         **/

        [Route("ping")]
        public IActionResult Ping()
        {
            return Healtcheck("");
        }
    }
}
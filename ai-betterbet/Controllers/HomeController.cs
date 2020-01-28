using Microsoft.AspNetCore.Mvc;
using System;

namespace ai_betterbet.Controllers
{
    /**
     * Main Controller
     **/

    public class HomeController : Controller
    {
       

        public static string MESSAGE_HEALTHY => "healthy";

        /**
* Main Entry Page
*/

        public IActionResult Index()
        {
            return View();
        }

        /**
         * Displays information about tests for the project
         */

        [Route("Tests")]
        public IActionResult Tests()
        {
            return View();
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
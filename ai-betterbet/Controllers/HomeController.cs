using Microsoft.AspNetCore.Mvc;
using System;

namespace ai_betterbet.Controllers
{
    public class HomeController : Controller
    {
        private const String MESSAGE_HEALTHY = "healthy";
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

        ///
        ///<summary>Simple "ping" endpoint used to check if app is up from the monitoring system</summary>
        ///
        ///
        [Route("healthcheck")]
        [Route("home/healthcheck")]
        public IActionResult Healtcheck(String message = MESSAGE_HEALTHY)
        {
            return Content(message);
        }

        [Route("ping")]
        public IActionResult Ping()
        {
            return Healtcheck("");
        }

    }
}
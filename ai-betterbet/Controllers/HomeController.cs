using Microsoft.AspNetCore.Mvc;
using System;

namespace ai_betterbet.Controllers
{
    public class HomeController : Controller
    {
        private const String MESSAGE_HEALTHY = "healthy";
        public IActionResult Index()
        {
            return View();
        }

        [Route("Tests")]
        public IActionResult Tests()
        {
            return View();
        }

        [Route("healthcheck")]
        [Route("home/healthcheck")]
        public IActionResult Healtcheck(String mesage = MESSAGE_HEALTHY)
        {
            return Content(MESSAGE_HEALTHY);
        }

        [Route("ping")]
        public IActionResult Ping()
        {
            return Healtcheck("");
        }

    }
}
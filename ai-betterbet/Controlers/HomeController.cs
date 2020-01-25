using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GiveNTake.Controlers
{
    public class HomeController : Controller
    {
        private const String MESSAGE_HEALTHY = "healthy";
        public IActionResult Index()
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
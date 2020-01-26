using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ai_betterbet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
     
        private const string _GitHubURL = "https://github.com/gabrielstar/ai_betterbet/tree/master/ai-betterbet";
        private const string _PostmanTestsURL = "https://www.getpostman.com/collections/d5c4dd3cd8c4a56bcb1d";

        string GitHubURL { 
            get { 
                return 
                    $"GitHub URL:{_GitHubURL}" +
                    $"\nPostman API tests: {_PostmanTestsURL}";
                }
        }
        [HttpGet]
        [HttpGet("info")]
        public string GetMessages()
        {
            return this.GitHubURL;
        }
    }
}
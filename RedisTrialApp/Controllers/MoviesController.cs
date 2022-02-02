using Microsoft.AspNetCore.Mvc;
using RedisTrialApp.TmdbServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedisTrialApp.Controllers
{
    [Route("api")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Please add a name at the end of the URL";
        }

        [HttpGet("{actorName}")]
        public async Task<List<string>> Get(string actorName)
        {
            return await GetMovieList(actorName);
        }

        private async Task<List<string>> GetMovieList(string actorName)
        {
            return await TmdbApiCall.GetMovieList(actorName);
        }
    }
}

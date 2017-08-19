using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MoviesTonight.Models;

namespace MoviesTonight.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public MovieInfo Get(int id)
        {
            var aMovie = new MovieInfo();
            aMovie.movieName = "asda";
            aMovie.discription = "sdadad";
            aMovie.pictureUrl = "asdada";
            return aMovie;
        }

    }
}

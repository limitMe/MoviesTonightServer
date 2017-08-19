using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MoviesTonight.Models;
using MoviesTonight.Support;

namespace MoviesTonight.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        // GET api/values/5
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            var aMovie = BasicInfo.Instance.movies.Find(x => x.movieName == name);

            if(aMovie == null){
                return NotFound();
            }

            return new ObjectResult(aMovie);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Mflix.Services;
using Mflix.Models;

namespace Mflix.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService movieService;

        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return movieService.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(string id)
        {
            return movieService.Get(id);
        }

        [HttpPost]
        public ActionResult<Movie> Post([FromBody]Movie movie)
        {
            movieService.Create(movie);

            return CreatedAtAction(nameof(Get), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody]Movie movie)
        {
            var movieExisting = movieService.Get(id);

            if (movieExisting == null)
            {
                return NotFound($"Movie with id = {id} not found");
            }

            movieService.Update(id, movie);

            return Ok($"Move updated");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var movie = movieService.Get(id);

            if(movie == null ) {
                return NotFound($"Movie with id = {id} not found");
            }

            movieService.Remove(movie.Id);

            return Ok($"Movie with id = {id} deleted");

        }
    }
}


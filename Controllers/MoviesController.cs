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

        [HttpGet("genre={genre}")]
        public ActionResult<List<Movie>> GetByGenre(string genre)
        {
            return movieService.GetByGenre(genre);
        }

        [HttpGet("wins")]
        public ActionResult<List<Movie>> GetByWins()
        {
            return movieService.GetMoviesWithAward();
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

        [HttpGet("released")]
        public ActionResult<List<Movie>> GetByReleaseDate(
        [FromQuery] DateTime? startDate,
        [FromQuery] DateTime? endDate)
        {
            if(startDate == null || endDate == null)
            {
                return BadRequest("You should provide an start date and end date");
            }
            
            var filteredMovies = movieService.GetMoviesByReleaseDate(startDate, endDate);

            if (filteredMovies == null || filteredMovies.Count == 0)
            {
                return NotFound("We dont found movies with this dates");
            }

            return filteredMovies;
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


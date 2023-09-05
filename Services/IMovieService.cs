using Mflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mflix.Services
{
	public interface IMovieService
	{
		List<Movie> Get();
		Movie Get(string id);
		Movie Create(Movie movie);
		void Update(string id, Movie movie);
		void Remove(string id);
        List<Movie> GetByGenre(string genre);
        List<Movie> GetMoviesWithAward();
		List<Movie> GetMoviesByReleaseDate(DateTime? startDate, DateTime? endDate);
    }
}


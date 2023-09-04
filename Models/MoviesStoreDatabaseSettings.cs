using System;
namespace Mflix.Models
{
	public class MoviesStoreDatabaseSettings : IMoviesStoreDatabaseSettings
	{
		public string MoviesCollectionName { get; set; } = String.Empty;
		public string ConnectionString { get; set; } = String.Empty;
		public string DatabaseName { get; set; } = String.Empty;
	}
}


﻿using Mflix.Models;
using MongoDB.Driver;

namespace Mflix.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMongoCollection<Movie> _movies;

        public MovieService(IMoviesStoreDatabaseSettings settings, IMongoClient mongoClient )
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _movies = database.GetCollection<Movie>(settings.MoviesCollectionName);
        }
        public Movie Create(Movie movie)
        {
            _movies.InsertOne(movie);
            return movie;
        }

        public List<Movie> Get()
        {
            return _movies.Find(movie => true).Limit(20).ToList();
        }

        public Movie Get(string id)
        {
            return _movies.Find(movie => movie.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _movies.DeleteOne(movie => movie.Id == id);
            
        }

        public void Update(string id, Movie movie)
        {
           _movies.ReplaceOne(movie => movie.Id == id, movie);
        }
    }
}


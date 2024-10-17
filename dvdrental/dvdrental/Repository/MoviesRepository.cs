using dvdrental.Entity;
using dvdrental.IRepository;
using Microsoft.Data.SqlClient;

namespace dvdrental.Repository
{
    public class MoviesRepository : IMovieRepository
    {
        private readonly string _connectionString;

        public MoviesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

      
        public async Task AddMovie(Movies movie)
        {
           
        }

     
        //public async Task<List<Movies>> GetAllMovies()
        //{
           
        //}

      
        //public async Task<Movies> GetMovieById(int id)
        //{
           
        //}

       
        //public async Task<List<Movies>> GetMoviesByCategory(int categoryId)
        //{
           
        //}

     
        //public async Task<List<Movies>> GetMoviesByDirector(string director)
        //{
           
        //}
        public async Task UpdateMovie(Movies movie)
        {
           
        }

        public async Task DeleteMovie(int id)
        {
          
        }

        public Task<List<Movies>> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public Task<Movies> GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movies>> GetMoviesByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movies>> GetMoviesByDirector(string director)
        {
            throw new NotImplementedException();
        }
    }
}


using dvdrental.DTOs.RequestDtos;
using dvdrental.DTOs.ResponceDtos;
using dvdrental.Entity;
using dvdrental.IRepository;
using dvdrental.IService;

namespace dvdrental.Service
{
    public class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;
       

        public MoviesService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
            
        }

        public async Task<MovieResponceDto> AddMovie(MoviesRequestDto request)
        {
           
        }

        public async Task<List<MovieResponceDto>> GetAllMovies()
        {
          
        }

        public async Task<MovieResponceDto> GetMovieById(int id)
        {
           
        }

        public async Task<List<MovieResponceDto>> GetMoviesByCategory(int categoryId)
        {
           
        }

        public async Task<List<MovieResponceDto>> GetMoviesByDirector(string director)
        {
        }

        public async Task<MovieResponceDto> UpdateMovie(int id, MoviesRequestDto request)
        {
           
        }

        public async Task<bool> DeleteMovie(int id)
        {
           
        }
    }
}

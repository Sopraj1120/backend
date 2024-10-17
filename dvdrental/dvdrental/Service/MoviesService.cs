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
            return new MovieResponceDto();
        }

        public async Task<List<MovieResponceDto>> GetAllMovies()
        {
            return new List<MovieResponceDto>();


        }

        public async Task<MovieResponceDto> GetMovieById(int id)
        {
            return new MovieResponceDto { Id = id };
        }

        public async Task<List<MovieResponceDto>> GetMoviesByCategory(int categoryId)
        {
            return new List<MovieResponceDto> { new MovieResponceDto { CategoryId = categoryId } };
        }

        public async Task<List<MovieResponceDto>> GetMoviesByDirector(string director)
        {
            return new List<MovieResponceDto>();
        }

        public async Task<MovieResponceDto> UpdateMovie(int id, MoviesRequestDto request)
        {
            return new MovieResponceDto();
           
        }

        public async Task<bool> DeleteMovie(int id)
        {
            return true;
            
        }
    }
}

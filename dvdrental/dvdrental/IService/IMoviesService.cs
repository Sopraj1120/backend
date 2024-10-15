using dvdrental.DTOs.RequestDtos;
using dvdrental.DTOs.ResponceDtos;

namespace dvdrental.IService
{
    public interface IMoviesService
    {
        Task<MovieResponceDto> AddMovie(MoviesRequestDto request);
        Task<List<MovieResponceDto>> GetAllMovies();
        Task<MovieResponceDto> GetMovieById(int id);
        Task<List<MovieResponceDto>> GetMoviesByCategory(int categoryId);
        Task<List<MovieResponceDto>> GetMoviesByDirector(string director);
        Task<MovieResponceDto> UpdateMovie(int id, MoviesRequestDto request);
        Task<bool> DeleteMovie(int id);
    }
}

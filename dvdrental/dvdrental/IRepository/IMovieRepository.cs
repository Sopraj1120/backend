using dvdrental.Entity;

namespace dvdrental.IRepository
{
    public interface IMovieRepository
    {
        Task AddMovie(Movies movie);
        Task<List<Movies>> GetAllMovies();
        Task<Movies> GetMovieById(int id);
        Task<List<Movies>> GetMoviesByCategory(int categoryId);
        Task<List<Movies>> GetMoviesByDirector(string director);
        Task UpdateMovie(Movies movie);
        Task DeleteMovie(int id);
    }
}

using dvdrental.Entity;

namespace dvdrental.IRepository
{
    public interface ICategoryRepository
    {
        Task AddCategory(string name);
        Task UpdateCategory(int id, string name);
        Task DeleteCategory(int id);
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryById(int id);
    }
}

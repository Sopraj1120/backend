using dvdrental.Entity;
using dvdrental.IRepository;
using Microsoft.Data.SqlClient;

namespace dvdrental.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string _connectionString;

        public CategoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddCategory(string name)
        {
           
        }

        public async Task UpdateCategory(int id, string name)
        {
           
        }

        public async Task DeleteCategory(int id)
        {
            
            
        }

        public async Task<List<Category>> GetCategories()
        {
           
        }

        public async Task<Category> GetCategoryById(int id)
        {
           
        }
    }
}

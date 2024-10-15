using dvdrental.DTOs.RequestDtos;
using dvdrental.DTOs.ResponceDtos;
using dvdrental.IRepository;
using dvdrental.IService;

namespace dvdrental.Service
{
    public class CategoryService :ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategory(CategoryRequestDto categoryDto)
        {
         
        }

        public async Task UpdateCategory(int id, CategoryRequestDto categoryDto)
        {
            
        }

        public async Task DeleteCategory(int id)
        {
       
        }

        public async Task<List<CategoryResponceDto>> GetCategories()
        {
           
        }

        public async Task<CategoryResponceDto> GetCategoryById(int id)
        {
           
        }
    }
}

using ECommerceBlazorApp.Shared;

namespace ECommerceBlazorApp.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryurl);
    }
}
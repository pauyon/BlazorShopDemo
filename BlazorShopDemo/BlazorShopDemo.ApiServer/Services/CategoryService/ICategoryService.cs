using BlazorShopDemo.Domain.Models;

namespace BlazorShopDemo.ApiServer.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryurl);
    }
}
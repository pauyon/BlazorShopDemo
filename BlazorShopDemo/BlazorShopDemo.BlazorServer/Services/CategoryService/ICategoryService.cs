using BlazorShopDemo.Domain.Models;

namespace BlazorShopDemo.BlazorServer.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        public Task GetCategories();
    }
}
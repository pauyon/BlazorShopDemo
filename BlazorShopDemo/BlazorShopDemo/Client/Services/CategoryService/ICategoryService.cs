using BlazorShopDemo.Shared;

namespace BlazorShopDemo.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        public Task GetCategories();
    }
}
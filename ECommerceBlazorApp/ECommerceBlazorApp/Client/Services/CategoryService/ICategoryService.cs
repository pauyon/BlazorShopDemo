using ECommerceBlazorApp.Shared;

namespace ECommerceBlazorApp.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        void LoadCategories();
    }
}
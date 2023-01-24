using ECommerceBlazorApp.Server.Data;
using ECommerceBlazorApp.Server.Services.CategoryService;
using ECommerceBlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBlazorApp.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _dataContext;

        public ProductService(ICategoryService categoryService, DataContext dataContext)
        {
            _categoryService = categoryService;
            _dataContext = dataContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dataContext.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _dataContext.Products
                .Include(p => p.Editions).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            var category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _dataContext.Products
                .Include(p => p.Editions).Where(p => p.CategoryId == category.Id).ToListAsync();
        }
    }
}
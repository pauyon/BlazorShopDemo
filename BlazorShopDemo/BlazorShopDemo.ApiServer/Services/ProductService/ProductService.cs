using BlazorShopDemo.ApiServer.Data;
using BlazorShopDemo.ApiServer.Services.CategoryService;
using BlazorShopDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopDemo.ApiServer.Services.ProductService
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
            return await _dataContext.Products.Include(p => p.Variants).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _dataContext.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Views++;

            await _dataContext.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            var category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _dataContext.Products
                .Include(p => p.Variants)
                .Where(p => p.CategoryId == category.Id)
                .ToListAsync();
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _dataContext.Products
                .Where(p => p.Title.Contains(searchText) ||
                            p.Description.Contains(searchText)).ToListAsync();
        }
    }
}
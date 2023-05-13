using BlazorShopDemo.Domain.Models;

namespace BlazorShopDemo.BlazorWasm.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;

        List<Product> Products { get; set; }

        Task LoadProducts(string categoryUrl = null);

        Task<Product> GetProduct(int id);

        Task<List<Product>> SearchProducts(string searchText);
    }
}
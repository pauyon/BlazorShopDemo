using ECommerceBlazorApp.Shared;
using System.Net.Http.Json;

namespace ECommerceBlazorApp.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if (categoryUrl == null)
            {
                Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/product");
            }
            else
            {
                Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/product/category/{categoryUrl}");
            }

            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"api/product/{id}");
        }
    }
}
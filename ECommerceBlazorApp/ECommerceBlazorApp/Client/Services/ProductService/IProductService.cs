using ECommerceBlazorApp.Shared;

namespace ECommerceBlazorApp.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        void LoadProducts();
    }
}

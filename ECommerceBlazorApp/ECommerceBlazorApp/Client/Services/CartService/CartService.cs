using Blazored.LocalStorage;
using Blazored.Toast.Services;
using ECommerceBlazorApp.Client.Services.ProductService;
using ECommerceBlazorApp.Shared;

namespace ECommerceBlazorApp.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorageService, IToastService toastService, IProductService productService)
        {
            _localStorageService = localStorageService;
            _toastService = toastService;
            _productService = productService;
        }

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _localStorageService.GetItemAsync<List<ProductVariant>>("cart");

            if (cart == null)
            {
                cart = new List<ProductVariant>();
            }

            cart.Add(productVariant);
            await _localStorageService.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(productVariant.ProductId);
            _toastService.ShowSuccess($"{product.Title} added to cart");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var results = new List<CartItem>();

            var cart = await _localStorageService.GetItemAsync<List<ProductVariant>>("cart");

            if (cart == null)
            {
                return results;
            }

            foreach (var item in cart)
            {
                var product = await _productService.GetProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    EditionId = item.EditionId
                };

                var variant = product.Variants.Find(v => v.EditionId == item.EditionId);
                if (variant != null) 
                {
                    cartItem.EditionName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }

                results.Add(cartItem);
            }

            return results;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorageService.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorageService.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}

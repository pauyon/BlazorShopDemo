using Blazored.LocalStorage;
using Blazored.Toast.Services;
using BlazorShopDemo.Client.Services.ProductService;
using BlazorShopDemo.Shared;

namespace BlazorShopDemo.Client.Services.CartService
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

        public async Task AddToCart(CartItem _cartItem)
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var _sameCartItem = cart.Find(x => x.ProductId == _cartItem.ProductId);

            if (_sameCartItem == null)
            {
                cart.Add(_cartItem);
            }
            else
            {
                _sameCartItem.Quantity += _cartItem.Quantity;
            }

            await _localStorageService.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(_cartItem.ProductId);
            _toastService.ShowSuccess($"{product.Title} added to cart");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                return new List<CartItem>();
            }

            return cart;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId)!;
            cart.Remove(cartItem);

            await _localStorageService.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorageService.RemoveItemAsync("cart");
            OnChange.Invoke();
        }
    }
}
using ECommerceBlazorApp.Shared;

namespace ECommerceBlazorApp.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Star Wars Jedi Knight Dark Forces II",
                    Description = "Jedi Knight takes place in the year 5 ABY, one year after Return of the Jedi and four years after Dark Forces.",
                    Image = "./images/jedi-knight-cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.00m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Minecraft",
                    Description = "Explore procedurally generated 3D world with virtually infinite terrain and may discover and extract raw materials, craft tools and items, and build structures, earthworks, and machines.",
                    Image = "./images/minecraft-cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Street Fighter Anniversary Collection",
                    Description = "Bundle of two Street Fighter games: Hyper Street Fighter II, and Street Fighter III: 3rd Strike.",
                    Image = "./images/street-fighter.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 4,
                    Title = "Star Ocean: Till The End of Time",
                    Description = "An action role-playing game, the third main game in the Star Ocean series. The game was developed by tri-Ace and published by Square Enix for the PlayStation 2 console.",
                    Image = "./images/star-ocean-tteot.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 5,
                    Title = "Kingdom Hearts II",
                    Description = "The game is a sequel to Kingdom Hearts, and like the original game, combines characters and settings from Disney films with those of Square Enix's Final Fantasy series",
                    Image = "./images/kingdom-hearts-2.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                }
            };
        }
    }
}
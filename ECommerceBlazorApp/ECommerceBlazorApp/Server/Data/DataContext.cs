using ECommerceBlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBlazorApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 3,
                    Title = "Star Wars Jedi Knight Dark Forces II",
                    Description = "Jedi Knight takes place in the year 5 ABY, one year after Return of the Jedi and four years after Dark Forces.",
                    Image = "./images/jedi-knight-cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.00m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Minecraft",
                    Description = "Explore procedurally generated 3D world with virtually infinite terrain and may discover and extract raw materials, craft tools and items, and build structures, earthworks, and machines.",
                    Image = "./images/minecraft-cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Street Fighter Anniversary Collection",
                    Description = "Bundle of two Street Fighter games: Hyper Street Fighter II, and Street Fighter III: 3rd Strike.",
                    Image = "./images/street-fighter.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "Star Ocean: Till The End of Time",
                    Description = "An action role-playing game, the third main game in the Star Ocean series. The game was developed by tri-Ace and published by Square Enix for the PlayStation 2 console.",
                    Image = "./images/star-ocean-tteot.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 3,
                    Title = "Kingdom Hearts II",
                    Description = "The game is a sequel to Kingdom Hearts, and like the original game, combines characters and settings from Disney films with those of Square Enix's Final Fantasy series.",
                    Image = "./images/kingdom-hearts-2.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Gameboy Color",
                    Description = "Nintendo handheld gaming console.",
                    Image = "./images/gbc.jpg",
                    Price = 80.00m,
                    OriginalPrice = 110.00m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Super Nintendo Entertainment System",
                    Description = "Nintendo gaming console.",
                    Image = "./images/snes.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Canon AE01",
                    Description = "Vintage Canon film camera.",
                    Image = "./images/canon-ae-1.jpg",
                    Price = 150.00m,
                    OriginalPrice = 200.00m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 1,
                    Title = "Atomic Habits",
                    Description = "A book about minuscule changes to habits for big changes in your life.",
                    Image = "./images/atomic-habits.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 1,
                    Title = "The Sublte Art Of Not Giving a F*ck",
                    Description = "A book about minuscule changes to habits for big changes in your life.",
                    Image = "./images/the-subtle-art.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 1,
                    Title = "Marcus Aurelius: Meditations",
                    Description = "A series of personal writings by Marcus Aurelius, Roman Emperor from AD 161 to 180, recording his private notes to himself and ideas on Stoic philosophy.",
                    Image = "./images/meditations.jpg",
                    Price = 11.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2023, 1, 1)
                }
                );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "PaperBack" },
                new Edition { Id = 2, Name = "E-Book" },
                new Edition { Id = 3, Name = "Audiobook" },
                new Edition { Id = 4, Name = "PC" },
                new Edition { Id = 5, Name = "PlayStation" },
                new Edition { Id = 6, Name = "Xbox" }
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
                .HasData(
                    new { EditionsId = 1, ProductsId = 9 },
                    new { EditionsId = 2, ProductsId = 9 },
                    new { EditionsId = 3, ProductsId = 9 },
                    new { EditionsId = 1, ProductsId = 10 },
                    new { EditionsId = 2, ProductsId = 10 },
                    new { EditionsId = 3, ProductsId = 10 },
                    new { EditionsId = 1, ProductsId = 11 },
                    new { EditionsId = 2, ProductsId = 11 },
                    new { EditionsId = 3, ProductsId = 11 },
                    new { EditionsId = 4, ProductsId = 2 },
                    new { EditionsId = 5, ProductsId = 2 },
                    new { EditionsId = 6, ProductsId = 2 }
                );
        }
    }
}
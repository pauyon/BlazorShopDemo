using BlazorShopDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopDemo.ApiServer.Data
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
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

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
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Minecraft",
                    Description = "Explore procedurally generated 3D world with virtually infinite terrain and may discover and extract raw materials, craft tools and items, and build structures, earthworks, and machines.",
                    Image = "./images/minecraft-cover.jpg",
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Title = "Gameboy Color",
                    Description = "Nintendo handheld gaming console.",
                    Image = "./images/gbc.jpg",
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Super Nintendo Entertainment System",
                    Description = "Nintendo gaming console.",
                    Image = "./images/snes.jpg",
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 1,
                    Title = "Atomic Habits",
                    Description = "A book about minuscule changes to habits for big changes in your life.",
                    Image = "./images/atomic-habits.jpg",
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 1,
                    Title = "Marcus Aurelius: Meditations",
                    Description = "A series of personal writings by Marcus Aurelius, Roman Emperor from AD 161 to 180, recording his private notes to himself and ideas on Stoic philosophy.",
                    Image = "./images/meditations.jpg",
                    DateCreated = new DateTime(2023, 1, 1)
                }
                );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "PaperBack" },
                new Edition { Id = 3, Name = "E-Book" },
                new Edition { Id = 4, Name = "Audiobook" },
                new Edition { Id = 5, Name = "PC" },
                new Edition { Id = 6, Name = "PlayStation" },
                new Edition { Id = 7, Name = "Xbox" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 5,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 5,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 6,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 7,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 1,
                    Price = 49.99m,
                    OriginalPrice = 99.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 99.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 2,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 3,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 4,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 2,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 3,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 4,
                    Price = 14.99m
                });
        }
    }
}
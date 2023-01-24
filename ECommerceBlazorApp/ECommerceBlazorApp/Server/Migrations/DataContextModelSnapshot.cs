﻿// <auto-generated />
using System;
using ECommerceBlazorApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerceBlazorApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerceBlazorApp.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Name = "Electronics",
                            Url = "electronics"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "aperture",
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("ECommerceBlazorApp.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");
                });

            modelBuilder.Entity("ECommerceBlazorApp.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Jedi Knight takes place in the year 5 ABY, one year after Return of the Jedi and four years after Dark Forces.",
                            Image = "./images/jedi-knight-cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.00m,
                            Price = 9.99m,
                            Title = "Star Wars Jedi Knight Dark Forces II"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Explore procedurally generated 3D world with virtually infinite terrain and may discover and extract raw materials, craft tools and items, and build structures, earthworks, and machines.",
                            Image = "./images/minecraft-cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 8.19m,
                            Title = "Minecraft"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bundle of two Street Fighter games: Hyper Street Fighter II, and Street Fighter III: 3rd Strike.",
                            Image = "./images/street-fighter.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 8.19m,
                            Title = "Street Fighter Anniversary Collection"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An action role-playing game, the third main game in the Star Ocean series. The game was developed by tri-Ace and published by Square Enix for the PlayStation 2 console.",
                            Image = "./images/star-ocean-tteot.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 8.19m,
                            Title = "Star Ocean: Till The End of Time"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The game is a sequel to Kingdom Hearts, and like the original game, combines characters and settings from Disney films with those of Square Enix's Final Fantasy series.",
                            Image = "./images/kingdom-hearts-2.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 8.19m,
                            Title = "Kingdom Hearts II"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nintendo handheld gaming console.",
                            Image = "./images/gbc.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 110.00m,
                            Price = 80.00m,
                            Title = "Gameboy Color"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nintendo gaming console.",
                            Image = "./images/snes.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 8.19m,
                            Title = "Super Nintendo Entertainment System"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Vintage Canon film camera.",
                            Image = "./images/canon-ae-1.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 200.00m,
                            Price = 150.00m,
                            Title = "Canon AE01"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A book about minuscule changes to habits for big changes in your life.",
                            Image = "./images/atomic-habits.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Atomic Habits"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A book about minuscule changes to habits for big changes in your life.",
                            Image = "./images/the-subtle-art.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "The Sublte Art Of Not Giving a F*ck"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A series of personal writings by Marcus Aurelius, Roman Emperor from AD 161 to 180, recording his private notes to himself and ideas on Stoic philosophy.",
                            Image = "./images/meditations.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 11.99m,
                            Title = "Marcus Aurelius: Meditations"
                        });
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.Property<int>("EditionsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("EditionsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("EditionProduct");
                });

            modelBuilder.Entity("ECommerceBlazorApp.Shared.Product", b =>
                {
                    b.HasOne("ECommerceBlazorApp.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.HasOne("ECommerceBlazorApp.Shared.Edition", null)
                        .WithMany()
                        .HasForeignKey("EditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerceBlazorApp.Shared.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

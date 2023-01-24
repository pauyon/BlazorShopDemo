using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorShopDemo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Books", "books" },
                    { 2, "camera-slr", "Electronics", "electronics" },
                    { 3, "aperture", "Video Games", "video-games" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7201), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jedi Knight takes place in the year 5 ABY, one year after Return of the Jedi and four years after Dark Forces.", "./images/jedi-knight-cover.jpg", false, false, 10.00m, 9.99m, "Star Wars Jedi Knight Dark Forces II" },
                    { 2, 3, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7232), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore procedurally generated 3D world with virtually infinite terrain and may discover and extract raw materials, craft tools and items, and build structures, earthworks, and machines.", "./images/minecraft-cover.jpg", false, false, 29.99m, 8.19m, "Minecraft" },
                    { 3, 3, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7235), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bundle of two Street Fighter games: Hyper Street Fighter II, and Street Fighter III: 3rd Strike.", "./images/street-fighter.jpg", false, false, 29.99m, 8.19m, "Street Fighter Anniversary Collection" },
                    { 4, 3, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7267), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An action role-playing game, the third main game in the Star Ocean series. The game was developed by tri-Ace and published by Square Enix for the PlayStation 2 console.", "./images/star-ocean-tteot.jpg", false, false, 29.99m, 8.19m, "Star Ocean: Till The End of Time" },
                    { 5, 3, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7270), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game is a sequel to Kingdom Hearts, and like the original game, combines characters and settings from Disney films with those of Square Enix's Final Fantasy series.", "./images/kingdom-hearts-2.jpg", false, false, 29.99m, 8.19m, "Kingdom Hearts II" },
                    { 6, 2, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7271), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nintendo handheld gaming console.", "./images/gbc.jpg", false, false, 110.00m, 80.00m, "Gameboy Color" },
                    { 7, 2, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7273), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nintendo gaming console.", "./images/snes.jpg", false, false, 29.99m, 8.19m, "Super Nintendo Entertainment System" },
                    { 8, 2, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7275), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vintage Canon film camera.", "./images/canon-ae-1.jpg", false, false, 200.00m, 150.00m, "Canon AE01" },
                    { 9, 1, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A book about minuscule changes to habits for big changes in your life.", "./images/atomic-habits.jpg", false, false, 19.99m, 9.99m, "Atomic Habits" },
                    { 10, 1, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7278), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A book about minuscule changes to habits for big changes in your life.", "./images/the-subtle-art.jpg", false, false, 19.99m, 9.99m, "The Sublte Art Of Not Giving a F*ck" },
                    { 11, 1, new DateTime(2023, 1, 23, 14, 50, 24, 739, DateTimeKind.Local).AddTicks(7279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A series of personal writings by Marcus Aurelius, Roman Emperor from AD 161 to 180, recording his private notes to himself and ideas on Stoic philosophy.", "./images/meditations.jpg", false, false, 19.99m, 11.99m, "Marcus Aurelius: Meditations" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

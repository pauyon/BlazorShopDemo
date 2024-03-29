﻿using BlazorShopDemo.Domain.Models;
using System.Net.Http.Json;

namespace BlazorShopDemo.BlazorServer.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetCategories()
        {
            Categories = await _httpClient.GetFromJsonAsync<List<Category>>("api/category");
        }
    }
}
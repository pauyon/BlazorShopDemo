﻿using BlazorShopDemo.Domain.Models;

namespace BlazorShopDemo.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryurl);
    }
}
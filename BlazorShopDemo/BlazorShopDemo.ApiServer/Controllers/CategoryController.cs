﻿using BlazorShopDemo.ApiServer.Services.CategoryService;
using BlazorShopDemo.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShopDemo.ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());
        }
    }
}
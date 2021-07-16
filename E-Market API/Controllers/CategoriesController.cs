using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Market_API.Domain.Models;
using E_Market_API.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Market_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllASync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}

using KitchenEquip.Services;
using KitchenEquip.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KitchenEquip.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IProductService productService, ILogger<HomeController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string? category, string? search)
        {
            var viewModel = new HomeViewModel
            {
                SelectedCategory = category,
                SearchTerm = search,
                Categories = await _productService.GetCategoriesAsync()
            };

            if (!string.IsNullOrWhiteSpace(search))
                viewModel.Products = await _productService.SearchAsync(search);
            else if (!string.IsNullOrWhiteSpace(category))
                viewModel.Products = await _productService.GetByCategoryAsync(category);
            else
                viewModel.Products = await _productService.GetAllAsync();

            return View(viewModel);
        }
    }
}

using KitchenEquip.Services;
using KitchenEquip.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KitchenEquip.Controller
{
    public class ProductsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [Route("produto/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                _logger.LogWarning("Produto {Id} não encontrado.", id);
                return NotFound();
            }

            var related = await _productService.GetRelatedAsync(id, 3);

            var viewModel = new ProductDetailViewModel
            {
                Product = product,
                RelatedProducts = related
            };

            return View(viewModel);
        }
    }
}

using KitchenEquip.Services;
using KitchenEquip.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KitchenEquip.Controllers // Geralmente no plural
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

        public async Task<IActionResult> Index(string search, string category, int page = 1)
        {
            int pageSize = 8; // Limite de 8 produtos por página

            // 1. Puxa todos os produtos e as categorias do Mock
            var allProducts = await _productService.GetAllAsync();
            var categories = await _productService.GetCategoriesAsync();

            // 2. Transforma em Queryable para podermos aplicar os filtros dinamicamente
            var query = allProducts.AsQueryable();

            // Aplica o filtro de Categoria (se o usuário tiver clicado em alguma)
            if (!string.IsNullOrWhiteSpace(category))
            {
                query = query.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }

            // Aplica o filtro de Busca (se o usuário digitou algo)
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p =>
                    p.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.ShortDescription.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            // 3. Calcula a paginação com base nos resultados filtrados
            var totalItems = query.Count();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // Garante que a página atual não ultrapasse o total de páginas
            if (page > totalPages && totalPages > 0) page = totalPages;
            if (page < 1) page = 1;

            // 4. Pega apenas os 8 produtos da página específica
            var pagedProducts = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            // 5. Monta o ViewModel COMPLETÃO para a View não quebrar
            var model = new HomeViewModel
            {
                Products = pagedProducts,
                Categories = categories,          // Necessário para os botões de filtro
                SearchTerm = search,              // Mantém o texto na barra de busca
                SelectedCategory = category,      // Deixa o botão da categoria "ativo" (azul)
                CurrentPage = page,               // Para o botão da página ficar "ativo"
                TotalPages = totalPages           // Para desenhar a quantidade certa de botões de paginação
            };

            return View(model);
        }
    }
}
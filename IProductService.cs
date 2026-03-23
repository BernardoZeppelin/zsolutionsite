using KitchenEquip.Models;

namespace KitchenEquip.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<List<Product>> GetByCategoryAsync(string category);
        Task<List<Product>> SearchAsync(string term);
        Task<List<string>> GetCategoriesAsync();
        Task<List<Product>> GetRelatedAsync(int productId, int count = 3);
    }
}

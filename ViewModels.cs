using KitchenEquip.Models;

namespace KitchenEquip.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; } = new();
        public List<string> Categories { get; set; } = new();
        public string? SelectedCategory { get; set; }
        public string? SearchTerm { get; set; }
    }

    public class ProductDetailViewModel
    {
        public Product Product { get; set; } = new();
        public List<Product> RelatedProducts { get; set; } = new();
    }

    public class AboutViewModel
    {
        public ContactInfo Contact { get; set; } = new();
    }
}

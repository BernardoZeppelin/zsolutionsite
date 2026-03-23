namespace KitchenEquip.Models
{
    // A classe principal do produto se mantém enxuta e focada
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ex: "FT 807 EL TOP"
        public string ShortDescription { get; set; } = string.Empty; // Texto curto ao lado da imagem
        public string FullDescription { get; set; } = string.Empty; // Os parágrafos maiores sobre tecnologia/economia
        public string ImageUrl { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // Ex: "Frytop Green Energy" ou "Grelhadores"
        public bool IsAvailable { get; set; } = true;

        // A mágica acontece aqui: conectando a ficha técnica
        public TechnicalSpec TechnicalSpec { get; set; } = new();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

}
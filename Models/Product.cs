using System.Text.Json.Serialization;

namespace proba1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        public ICollection<CartItem>? CartItems { get; set; }
    }
}

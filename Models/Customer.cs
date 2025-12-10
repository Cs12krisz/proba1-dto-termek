using System.Text.Json.Serialization;

namespace proba1.Models
{
    public class Customer
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? Name { get; set; }

        [JsonIgnore]
        public ICollection<CartItem>? CartItems { get; set; }
    }
}

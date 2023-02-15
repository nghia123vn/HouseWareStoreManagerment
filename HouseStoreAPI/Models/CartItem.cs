#nullable disable

using System.Text.Json.Serialization;

namespace HouseStoreAPI.Models
{
    public partial class CartItem
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalPriceItem { get; set; }
        [JsonIgnore]
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}

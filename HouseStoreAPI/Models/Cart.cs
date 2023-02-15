using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace HouseStoreAPI.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public DateTime UpDate { get; set; }
        public int? TotalPrice { get; set; }
        [JsonIgnore]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}

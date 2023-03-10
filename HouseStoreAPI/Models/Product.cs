using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace HouseStoreAPI.Models
{
	public partial class Product
	{
		public Product()
		{
			CartItems = new HashSet<CartItem>();
			OrderItems = new HashSet<OrderItem>();
		}

		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string Image { get; set; }
		public int Price { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }
		public bool? Status { get; set; }
		public int CategoryId { get; set; }
		[JsonIgnore]
		public virtual Category Category { get; set; }
		public virtual ICollection<CartItem> CartItems { get; set; }
		public virtual ICollection<OrderItem> OrderItems { get; set; }
	}
}

using System;
using System.Collections.Generic;

#nullable disable

namespace HouseStoreAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int? TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Shipment Shipment { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

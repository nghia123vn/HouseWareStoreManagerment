using System;
using System.Collections.Generic;

#nullable disable

namespace HouseStoreAPI.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalPriceItem { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}

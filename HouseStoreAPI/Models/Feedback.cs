using System;
using System.Collections.Generic;

#nullable disable

namespace HouseStoreAPI.Models
{
    public partial class Feedback
    {
        public int OrderItemId { get; set; }
        public int FeedbackId { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }

        public virtual OrderItem OrderItem { get; set; }
    }
}

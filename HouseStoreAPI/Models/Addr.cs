using System;
using System.Collections.Generic;

#nullable disable

namespace HouseStoreAPI.Models
{
    public partial class Addr
    {
        public int AddrId { get; set; }
        public string Addr1 { get; set; }
        public bool? IsDefault { get; set; }
        public bool? DelFlg { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}

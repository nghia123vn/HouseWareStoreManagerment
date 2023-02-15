using System;
using System.Collections.Generic;

#nullable disable

namespace HouseStoreAPI.Models
{
    public partial class Shipment
    {
        public int ShipmentId { get; set; }
        public int OrderId { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int AddrId { get; set; }

        public virtual Addr Addr { get; set; }
        public virtual Order Order { get; set; }
    }
}

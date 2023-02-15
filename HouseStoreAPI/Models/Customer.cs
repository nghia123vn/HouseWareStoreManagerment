using System;
using System.Collections.Generic;

#nullable disable

namespace HouseStoreAPI.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Addrs = new HashSet<Addr>();
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual ICollection<Addr> Addrs { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

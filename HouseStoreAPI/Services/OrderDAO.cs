using HouseStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseStoreAPI.Services
{
    public class OrderDAO
    {
        private readonly HousewareStoreManagermentContext _context;

        public OrderDAO()
        {
            _context = new HousewareStoreManagermentContext();
        }

        public OrderDAO(HousewareStoreManagermentContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrderByCusStaAsync(int customerId, string status)
        {
            return await _context.Orders
                .Where(o => o.Status.Equals(status) && o.Customer.CustomerId == customerId).ToListAsync();

        }

        public void CancelOrder(int orderId)
        {
            var order = _context.Orders.FirstOrDefault(ci => ci.OrderId == orderId);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            order.Status = "cancel";
            _context.SaveChanges();
        }
    }
}

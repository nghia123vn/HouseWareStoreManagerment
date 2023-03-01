using HouseStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseStoreAPI.Services
{
    public class OrderItemDAO
    {
        private readonly HousewareStoreManagermentContext _context;

        public OrderItemDAO()
        {
            _context = new HousewareStoreManagermentContext();
        }

        public OrderItemDAO(HousewareStoreManagermentContext context)
        {
            _context = context;
        }
        public async Task<List<OrderItem>> GetOrderByCusStaAsync(int orderId)
        {
            return await _context.OrderItems
                .Include(o => o.Product)
                .Select(p => new OrderItem
                {
                    OrderItemId = p.OrderItemId,
                    OrderId= p.OrderId,
                    ProductId= p.ProductId,
                    Quantity= p.Quantity,
                    TotalPriceItem= p.TotalPriceItem,
                    Product = p.Product
                }).ToListAsync();

        }
    }
}

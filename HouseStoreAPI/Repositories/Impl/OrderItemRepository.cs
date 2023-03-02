using HouseStoreAPI.Models;
using HouseStoreAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories.Impl
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly OrderItemDAO orderItemDAO;

        public OrderItemRepository()
        {
            this.orderItemDAO = new OrderItemDAO();
        }

        public OrderItemRepository(OrderItemDAO orderItemDAO)
        {
            this.orderItemDAO = orderItemDAO;
        }
        public Task<OrderItem> AddOrderItemAsync(OrderItem order)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteOrderAsync(OrderItem order)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<OrderItem>> GetOrderItemByIdAsync(int id)
        {
            return await orderItemDAO.GetOrderByCusStaAsync(id);
        }

        public Task<OrderItem> UpdateOrderItemAsync(OrderItem order)
        {
            throw new System.NotImplementedException();
        }
    }
}

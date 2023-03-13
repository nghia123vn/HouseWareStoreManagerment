using HouseStoreAPI.Models;
using HouseStoreAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories.Impl
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO orderDAO;

        public OrderRepository()
        {
            this.orderDAO = new OrderDAO();
        }

        public OrderRepository(OrderDAO orderDAO)
        {
            this.orderDAO = orderDAO;
        }
        public Task<Order> AddOrderAsync(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void CancelOrder(int orderId)
        => orderDAO.CancelOrder(orderId);

        public Task DeleteOrderAsync(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Task<Order> GetOrderByIdAsync(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Order>> GetOrderByIdAsync(int customerId, string status)
        {
            return await orderDAO.GetOrderByCusStaAsync(customerId, status);
        }

        public Task<Order> UpdateOrderAsync(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}

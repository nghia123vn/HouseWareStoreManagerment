using HouseStoreAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> AddOrderAsync(Order order);
        Task<Order?> UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(Order order);
        Task<List<Order>> GetOrderByIdAsync(int id, string status);
        void CancelOrder(int orderId);
    }
}

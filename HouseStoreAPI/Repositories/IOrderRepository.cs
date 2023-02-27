using HouseStoreAPI.Models;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface IOrderRepository
    {
        Task<Order?> GetOrderByIdAsync(string customerId);
        Task<Order> AddOrderAsync(Order order);
        Task<Order?> UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(Order order);
    }
}

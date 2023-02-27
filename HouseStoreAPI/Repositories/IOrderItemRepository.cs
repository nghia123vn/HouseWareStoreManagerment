using HouseStoreAPI.Models;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface IOrderItemRepository
    {
        Task<OrderItem?> GetOrderItemByIdAsync(string customerId, string productId);
        Task<OrderItem> AddOrderItemAsync(OrderItem order);
        Task<OrderItem?> UpdateOrderItemAsync(OrderItem order);
        Task DeleteOrderAsync(OrderItem order);
    }
}

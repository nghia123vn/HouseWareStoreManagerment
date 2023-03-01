using HouseStoreAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface IOrderItemRepository
    {
        Task<OrderItem> AddOrderItemAsync(OrderItem order);
        Task<OrderItem?> UpdateOrderItemAsync(OrderItem order);
        Task DeleteOrderAsync(OrderItem order);
        Task<List<OrderItem>> GetOrderItemByIdAsync(int id);
    }
}

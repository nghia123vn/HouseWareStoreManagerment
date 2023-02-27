using HouseStoreAPI.Models;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface ICartItemRepository
    {
        Task<CartItem?> GetCartItemByIdAsync(string customerId);
        Task<CartItem> AddCartItemAsync(CartItem cartItem);
        Task<CartItem?> UpdateCartItemAsync(CartItem cartItem);
        Task DeleteCartItemAsync(CartItem cartItem);
    }
}

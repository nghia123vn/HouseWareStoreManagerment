using HouseStoreAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
	public interface ICartItemRepository
	{
		Task<CartItem?> GetCartItemByIdAsync(string customerId);
		Task<CartItem> AddCartItemAsync(CartItem cartItem);
		Task<CartItem?> UpdateCartItemAsync(CartItem cartItem);
		Task DeleteCartItemAsync(CartItem cartItem);

		public Task<List<Product>> GetProductsInCart(int cartId);
		public void UpdateProductQuantity(int cartId, int productId, int quantity);
		public void DeleteCartItem(int cartId, int productId);

	}
}

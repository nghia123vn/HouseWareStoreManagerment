using HouseStoreAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
	public interface ICartItemRepository
	{
		Task<CartItem?> GetCartItemByIdAsync(string customerId);
        public void AddProductToCart(int cartId, int productId, int quantity);
        Task<CartItem?> UpdateCartItemAsync(CartItem cartItem);
		Task DeleteCartItemAsync(CartItem cartItem);

		public Task<List<Product>> GetProductsInCart(int cartId);
		public void UpdateProductQuantity(int cartId, int productId, int quantity);
		public void DeleteCartItem(int cartId, int productId);
		public void DeleteAllCartItem(int cartId);

	}
}

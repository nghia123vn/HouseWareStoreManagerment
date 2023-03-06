using HouseStoreAPI.Models;
using HouseStoreAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories.Impl
{
	public class CartItemRepository : ICartItemRepository
	{
		private readonly CartItemDAO _cartItemDAO;
		public CartItemRepository(CartItemDAO cartItemDAO)
		{
			_cartItemDAO = cartItemDAO;
		}
		public Task<CartItem> AddCartItemAsync(CartItem cartItem)
		{
			throw new System.NotImplementedException();
		}
		public Task DeleteCartItemAsync(CartItem cartItem)
		{
			throw new System.NotImplementedException();
		}

		public Task<CartItem> GetCartItemByIdAsync(string customerId)
		{
			throw new System.NotImplementedException();
		}
		public Task<CartItem> UpdateCartItemAsync(CartItem cartItem)
		{
			throw new System.NotImplementedException();
		}

		public void DeleteCartItem(int cartId, int productId)
		=> _cartItemDAO.DeleteCartItem(cartId, productId);

		public Task<List<Product>> GetProductsInCart(int cartId)
		=> _cartItemDAO.GetProductsInCart(cartId);

		public void UpdateProductQuantity(int cartId, int productId, int quantity)
		=> _cartItemDAO.UpdateProductQuantity(cartId, productId, quantity);
	}
}

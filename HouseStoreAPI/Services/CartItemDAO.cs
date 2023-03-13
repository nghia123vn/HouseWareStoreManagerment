using HouseStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseStoreAPI.Services
{
	public class CartItemDAO
	{
		private readonly HousewareStoreManagermentContext _context;
		public CartItemDAO(HousewareStoreManagermentContext context)
		{
			_context = context;
		}

		public async Task<List<Product>> GetProductsInCart(int cartId)
		{
			var cartItems = await _context.CartItems
				.Where(ci => ci.CartId == cartId)
				.Include(ci => ci.Product)
				.ToListAsync();

			return cartItems.Select(ci => ci.Product).ToList();
		}

		public void UpdateProductQuantity(int cartId, int productId, int quantity)
		{
			var cartItem = _context.CartItems.FirstOrDefault(ci => ci.ProductId == productId && ci.CartId == cartId);

			if (cartItem == null)
			{
				throw new Exception("CartItem not found");
			}

			var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);

			if (product == null)
			{
				throw new Exception("Product not found");
			}

			cartItem.Quantity = quantity;
			cartItem.TotalPriceItem = quantity * product.Price;

			_context.SaveChanges();
		}

		public void DeleteCartItem(int cartId, int productId)
		{
			var cartItem = _context.CartItems.SingleOrDefault(ci => ci.ProductId == productId && ci.CartId == cartId);
			if (cartItem != null)
			{
				_context.CartItems.Remove(cartItem);
				_context.SaveChanges();
			}
		}
        public void DeleteAllItemInCart(int cartId)
        {
            var cartItems = _context.CartItems.Where(c => c.CartId == cartId);
            if (cartItems != null)
            {
                _context.CartItems.RemoveRange(cartItems);
                _context.SaveChanges();
            }
        }

        public void AddCartItem(int accountId, int productId, int quantity)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
			var account = _context.Customers.FirstOrDefault(c => c.CustomerId == accountId);

            if (product == null)
            {
                throw new Exception("Product not found");
            }
			int newCartId = 0;
			if (account == null)
			{
                var maxCartId = _context.CartItems.Max(c => c.CartId);
                newCartId = maxCartId + 1;
            } else
			{
				newCartId = _context.Carts.FirstOrDefault(ci => ci.Customer.CustomerId == accountId).CartId;
            }

            var newCartItem = new CartItem()
            {
                CartId = newCartId,
                ProductId = productId,
                Quantity = quantity,
                TotalPriceItem = quantity * product.Price
            };

            _context.CartItems.Add(newCartItem);
            _context.SaveChanges();
        }
    }
}

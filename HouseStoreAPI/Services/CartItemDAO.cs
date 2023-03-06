﻿using HouseStoreAPI.Models;
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
			var product = _context.CartItems.FirstOrDefault(p => p.ProductId == productId && p.CartId == cartId);

			if (product == null)
			{
				throw new Exception("Product not found");
			}

			product.Quantity = quantity;
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
	}
}
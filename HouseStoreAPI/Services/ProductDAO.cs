using HouseStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HouseStoreAPI.Services
{
	public class ProductDAO
	{
		private readonly HousewareStoreManagermentContext _context;

		public ProductDAO(HousewareStoreManagermentContext context)
		{
			_context = context;
		}

		public List<Product> GetAllProducts()
		{
			return _context.Products.Include(p => p.Category).ToList();
		}

		public List<Product> GetProductsByCategory(int categoryId)
		{
			return _context.Products.Where(p => p.CategoryId == categoryId).ToList();
		}
	}
}

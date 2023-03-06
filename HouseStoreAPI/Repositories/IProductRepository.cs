using HouseStoreAPI.Models;
using System.Collections.Generic;

namespace HouseStoreAPI.Repositories
{
	public interface IProductRepository
	{
		List<Product> GetAllProducts();
		public List<Product> GetProductsByCategory(int categoryId);
	}
}

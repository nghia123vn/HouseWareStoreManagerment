using HouseStoreAPI.Models;
using HouseStoreAPI.Services;
using System.Collections.Generic;

namespace HouseStoreAPI.Repositories.Impl
{
	public class ProductRepository : IProductRepository
	{
		private readonly ProductDAO _productDAO;

		public ProductRepository(ProductDAO productDAO)
		{
			_productDAO = productDAO;
		}

		public List<Product> GetAllProducts()
		{
			return _productDAO.GetAllProducts();
		}

		public List<Product> GetProductsByCategory(int categoryId)
		{
			return _productDAO.GetProductsByCategory(categoryId);
		}
	}
}

using HouseStoreAPI.Models;
using HouseStoreAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
		{
			var products = _productRepository.GetAllProducts();
			return Ok(products);
		}

		[HttpGet("category/{categoryId}")]
		public async Task<ActionResult<List<Product>>> GetProductsByCategory(int categoryId)
		{
			var products = _productRepository.GetProductsByCategory(categoryId);
			return products;
		}
	}
}

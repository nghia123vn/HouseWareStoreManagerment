using HouseStoreAPI.Models;
using HouseStoreAPI.Repositories;
using HouseStoreAPI.Repositories.Impl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController()
        {
            this.productRepository = new ProductRepository();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCart(int id)
        {
            var product = await productRepository.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}

using HouseStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly HousewareStoreManagermentContext _context;

        public CartController(HousewareStoreManagermentContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Cart>>> GetCartsWithCartItems()
        //{
        //    var carts = await _context.Carts.Include(c => c.CartItems).ToListAsync();
        //    return carts;
        //}
        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> GetCart(int id)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.CartId == id);

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cart>>> ListCart()
        {
            var carts = await _context.Carts.Include(c => c.CartItems).ToListAsync();
            return carts;
        }


    }
}

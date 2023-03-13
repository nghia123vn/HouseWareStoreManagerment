using HouseStoreAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HouseStoreAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartItemController : ControllerBase
	{
		private readonly ICartItemRepository _itemRepository;
		public CartItemController(ICartItemRepository itemRepository)
		{
			_itemRepository = itemRepository;
		}

		[HttpPost]
		public IActionResult UpdateProductQuantity(int cartId, int productId, int quantity)
		{
			try
			{
				_itemRepository.UpdateProductQuantity(cartId, productId, quantity);
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

        [HttpPost("/add-to-cart")]
        public IActionResult AddProductToCart(int cartId, int productId, int quantity)
        {
            try
            {
                _itemRepository.AddProductToCart(cartId, productId, quantity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{cartId}/{productId}")]
		public IActionResult DeleteCartItem(int cartId, int productId)
		{
			try
			{
				_itemRepository.DeleteCartItem(cartId, productId);
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

        [HttpDelete("{cartId}")]
        public IActionResult DeleteAllCartItem(int cartId)
        {
            try
            {
                _itemRepository.DeleteAllCartItem(cartId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

using HouseStoreAPI.Models;
using HouseStoreAPI.Repositories;
using HouseStoreAPI.Repositories.Impl;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HouseStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemRepository orderItemRepository;

        public OrderItemController()
        {
            this.orderItemRepository = new OrderItemRepository();
        }

        [HttpPost("/orderItem")]
        public async Task<IActionResult> GetOrderItem(int orderId)
        {
            var orderItem = await orderItemRepository.GetOrderItemByIdAsync(orderId);

            if (orderItem == null)
            {
                return NotFound();
            }
            return Ok(orderItem);
        }
    }
}

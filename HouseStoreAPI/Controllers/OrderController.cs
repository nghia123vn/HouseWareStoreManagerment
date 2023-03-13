using HouseStoreAPI.Models;
using HouseStoreAPI.Repositories;
using HouseStoreAPI.Repositories.Impl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace HouseStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;

        public OrderController()
        {
            this.orderRepository = new OrderRepository();
        }

        [HttpPost("/orders")]
        public async Task<IActionResult> GetOrder(int customerId, string status)
        {
            var order = await orderRepository.GetOrderByIdAsync(customerId, status);

            if  (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost("/cancel-order")]
        public IActionResult UpdateProductQuantity(int orderId)
        {
            try
            {
                orderRepository.CancelOrder(orderId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

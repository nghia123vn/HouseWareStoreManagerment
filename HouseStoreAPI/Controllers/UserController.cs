using HouseStoreAPI.Models;
using HouseStoreAPI.Repositories;
using HouseStoreAPI.Repositories.Impl;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HouseStoreAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		IUserRepository _userRepository = new UserRepository();
		[HttpGet("{username}/{password}")]
		public async Task<ActionResult<Customer>> Login(string username, string password)
		{
			var user = _userRepository.Login(username, password);
			return user;
		}

		[HttpPut("{customerId}/{password}")]
		public async Task<ActionResult<Customer>> ResetPassword(int customerId, string password, string confirmPassword)
		{
			var customer = _userRepository.GetCustomerById(customerId);

			if (customer == null)
			{
				return NotFound();
			}

			if (password != confirmPassword)
			{
				return BadRequest("Password and confirmation password do not match.");
			}

			customer.Password = password;
			_userRepository.Update(customer);

			return customer;
		}
	}
}

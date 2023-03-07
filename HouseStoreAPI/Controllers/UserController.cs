using HouseStoreAPI.Models;
using HouseStoreAPI.Repositories;
using HouseStoreAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HouseStoreAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		IUserRepository _userRepository;
		public UserController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
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

		[HttpPost("save")]
		public async Task<ActionResult<int>> Save(CustomerDto customerDto)
		{
			// check if email is valid
			if (!IsValidEmail(customerDto.Email))
			{
				return BadRequest("Invalid email format.");
			}

			// check if phone is valid
			if (!IsValidPhone(customerDto.Phone))
			{
				return BadRequest("Invalid phone number format.");
			}

			// Check if email and phone already exist
			if (await _userRepository.EmailExists(customerDto.Email))
			{
				return BadRequest("Email already exists");
			}

			if (await _userRepository.PhoneExists(customerDto.Phone))
			{
				return BadRequest("Phone already exists");
			}

			// save customer to database
			var customerId = await _userRepository.AddCustomer(customerDto);

			return Ok(customerId);
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		private bool IsValidPhone(string phone)
		{
			if (string.IsNullOrEmpty(phone))
			{
				return false;
			}
			// Remove all non-digit characters from the phone number
			var cleanedNumber = new string(phone.Where(char.IsDigit).ToArray());
			// Check if the cleaned number is a valid phone number with no more than 11 digits
			return Regex.IsMatch(cleanedNumber, @"^\d{1,11}$");
		}
	}
}

using HouseStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HouseStoreAPI.Services
{
	public class CustomerDto
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
	}

	public class UserDAO
	{
		private readonly HousewareStoreManagermentContext _dbContext;
		public UserDAO(HousewareStoreManagermentContext dbContext)
		{
			_dbContext = dbContext;
		}
		public static Customer Login(string username, string password)
		{
			using (var _context = new HousewareStoreManagermentContext())
			{
				var customer = _context.Customers.FirstOrDefault(user => user.UserName == username && user.Password == password);
				return customer;
			}
		}

		public static void Update(Customer user)
		{
			using (var _context = new HousewareStoreManagermentContext())
			{
				try
				{
					_context.Entry<Customer>(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
					_context.SaveChanges();
				}
				catch (Exception e)
				{
					throw new Exception(e.Message);
				}
			}
		}

		public static Customer GetCustomerById(int customerId)
		{
			using (var _context = new HousewareStoreManagermentContext())
			{
				return _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
			}
		}

		public async Task SaveUserAsync(Customer user)
		{
			using (var _context = new HousewareStoreManagermentContext())
			{
				_context.Customers.Add(user);
				await _context.SaveChangesAsync();
			}

		}

		public async Task<int> AddCustomer(Customer customer)
		{
			_dbContext.Customers.Add(customer);
			await _dbContext.SaveChangesAsync();
			return customer.CustomerId;
		}

		public async Task<bool> EmailExists(string email)
		{
			return await _dbContext.Customers.AnyAsync(c => c.Email == email);
		}

		public async Task<bool> PhoneExists(string phone)
		{
			return await _dbContext.Customers.AnyAsync(c => c.Phone == phone);
		}
	}
}

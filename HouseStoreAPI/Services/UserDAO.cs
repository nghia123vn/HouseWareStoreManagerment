using HouseStoreAPI.Models;
using System;
using System.Linq;

namespace HouseStoreAPI.Services
{
	public class UserDAO
	{
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
	}
}

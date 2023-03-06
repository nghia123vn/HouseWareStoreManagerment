using HouseStoreAPI.Models;
using HouseStoreAPI.Services;

namespace HouseStoreAPI.Repositories.Impl
{
	public class UserRepository : IUserRepository
	{
		public Customer GetCustomerById(int customerId)
		=> UserDAO.GetCustomerById(customerId);

		public Customer Login(string username, string password)
		=> UserDAO.Login(username, password);

		public void Update(Customer user)
		=> UserDAO.Update(user);
	}
}

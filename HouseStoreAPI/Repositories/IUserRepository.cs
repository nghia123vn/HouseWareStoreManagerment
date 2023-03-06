using HouseStoreAPI.Models;

namespace HouseStoreAPI.Repositories
{
	public interface IUserRepository
	{
		public Customer Login(string username, string password);
		public void Update(Customer user);
		public Customer GetCustomerById(int customerId);
	}
}

using HouseStoreAPI.Models;
using HouseStoreAPI.Services;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
	public interface IUserRepository
	{
		public Customer Login(string username, string password);
		public void Update(Customer user);
		public Customer GetCustomerById(int customerId);
		public Task SaveUserAsync(Customer user);
		Task<int> AddCustomer(CustomerDto customerDto);
		Task<bool> EmailExists(string email);
		Task<bool> PhoneExists(string phone);
	}
}

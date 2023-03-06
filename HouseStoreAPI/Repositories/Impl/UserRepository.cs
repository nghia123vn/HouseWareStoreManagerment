using HouseStoreAPI.Models;
using HouseStoreAPI.Services;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories.Impl
{
	public class UserRepository : IUserRepository
	{
		private readonly UserDAO _userDAO;
		public UserRepository(UserDAO userDAO)
		{
			_userDAO = userDAO;
		}

		public Task<int> AddCustomer(CustomerDto customerDto)
		{
			var customer = new Customer
			{
				UserName = customerDto.UserName,
				Password = customerDto.Password,
				FullName = customerDto.FullName,
				Email = customerDto.Email,
				Phone = customerDto.Phone
			};
			return _userDAO.AddCustomer(customer);
		}

		public Customer GetCustomerById(int customerId)
		=> UserDAO.GetCustomerById(customerId);

		public Customer Login(string username, string password)
		=> UserDAO.Login(username, password);

		public Task SaveUserAsync(Customer user)
		=> _userDAO.SaveUserAsync(user);
		public void Update(Customer user)
		=> UserDAO.Update(user);

		public async Task<bool> EmailExists(string email)
		=> await _userDAO.EmailExists(email);

		public async Task<bool> PhoneExists(string phone)
		=> await _userDAO.PhoneExists(phone);

	}
}

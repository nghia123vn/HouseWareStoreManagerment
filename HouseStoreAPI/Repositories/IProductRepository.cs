using HouseStoreAPI.Models;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface IProductRepository
    {
        Task<Product?> GetProductByIdAsync(int productId);
        Task<Product> AddProductAsync(Product product);
        Task<Product?> UpdateProductAsync(Product product);
        Task DeleteProductAsync(Product product);
    }
}

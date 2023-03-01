using HouseStoreAPI.Models;
using HouseStoreAPI.Services;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories.Impl
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO productDAO;

        public ProductRepository()
        {
            this.productDAO = new ProductDAO();
        }

        public ProductRepository(ProductDAO productDAO)
        {
            this.productDAO = productDAO;
        }
        public Task<Product> AddProductAsync(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteProductAsync(Product product)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await productDAO.GetProductByIdAsync(productId);
        }

        public Task<Product> UpdateProductAsync(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}

using HouseStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace HouseStoreAPI.Services
{
    public class ProductDAO
    {
        private readonly HousewareStoreManagermentContext _context;

        public ProductDAO()
        {
            _context= new HousewareStoreManagermentContext();
        }

        public ProductDAO(HousewareStoreManagermentContext context)
        {
            _context = context;
        }
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(c => c.ProductId == id);
        }
    }
}

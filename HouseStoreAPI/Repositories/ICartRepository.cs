using HouseStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface ICartRepository
    {
        Task<Cart?> GetCartByIdAsync(string id);
        Task<Cart> AddCartAsync(Cart contract);
        Task<Cart?> UpdateCartAsync(Cart contract);
        Task DeleteCartAsync(Cart contract);

    }
}

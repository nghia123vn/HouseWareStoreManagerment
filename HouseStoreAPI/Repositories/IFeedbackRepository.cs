using HouseStoreAPI.Models;
using System.Threading.Tasks;

namespace HouseStoreAPI.Repositories
{
    public interface IFeedbackRepository
    {
        Task<Feedback?> GetFeedbackByIdAsync(string productId);
        Task<Feedback> AddFeedbackAsync(Feedback feedback);
        Task<Feedback?> UpdateFeedbackAsync(Feedback feedback);
        Task DeleteFeedbackAsync(Feedback feedback);
    }
}

using TrainingymTest.DTOs;
using TrainingymTest.Models;

namespace TrainingymTest.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> FindAll();
        Task<Order?> FindById(long Id);
        Task<int> Create(List<Order> orders);
        Task<bool> Any();
        Task<LastOrderByMemberDTO?> GetLastOrderByMemberId(long Id);
    }
}

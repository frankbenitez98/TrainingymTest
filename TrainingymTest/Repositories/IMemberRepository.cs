using TrainingymTest.Models;

namespace TrainingymTest.Repositories
{
    public interface IMemberRepository
    {
        Task<List<Member>> FindAll();
        Task<Member?> FindById(long Id);
        Task<int> Create(List<Member> members);
        Task<bool> Any();
    }
}

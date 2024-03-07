using TrainingymTest.Models;

namespace TrainingymTest.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> FindAll();
        Task<Product?> FindById(long Id);
        Task<int> Create(List<Product> products);
        Task<bool> Any();
    }
}

using Microsoft.EntityFrameworkCore;
using TrainingymTest.Context;
using TrainingymTest.Models;

namespace TrainingymTest.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _context;

        public ProductRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<int> Create(List<Product> products)
        {
            _context.AddRange(products);
            await _context.SaveChangesAsync();
            return 0;
        }

        public async Task<List<Product>> FindAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> FindById(long Id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<bool> Any()
        {
            return await _context.Products.AnyAsync();
        }
    }
}

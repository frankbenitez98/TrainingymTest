using Microsoft.EntityFrameworkCore;
using TrainingymTest.Context;
using TrainingymTest.Models;

namespace TrainingymTest.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDBContext _context;

        public OrderRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<int> Create(List<Order> orders)
        {
            _context.AddRange(orders);
            await _context.SaveChangesAsync();
            return 0;
        }

        public async Task<List<Order>> FindAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order?> FindById(long Id)
        {
            return await _context.Orders.FirstOrDefaultAsync(x => x.Id == Id);
        }
        public async Task<bool> Any()
        {
            return await _context.Orders.AnyAsync();
        }
    }
}

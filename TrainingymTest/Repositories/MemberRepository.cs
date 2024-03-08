using Microsoft.EntityFrameworkCore;
using TrainingymTest.Context;
using TrainingymTest.Models;

namespace TrainingymTest.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly ApplicationDBContext _context;

        public MemberRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<int> Create(List<Member> members)
        {
            _context.AddRange(members);
            await _context.SaveChangesAsync();
            return 0;
        }

        public async Task<List<Member>> FindAll()
        {
            return await _context.Members.ToListAsync();
        }

        public async Task<Member?> FindById(long Id)
        {
            return await _context.Members.FirstOrDefaultAsync(x=>x.Id == Id);
        }

        public async Task<bool> Any()
        {
            return await _context.Members.AnyAsync();
        }
    }
}

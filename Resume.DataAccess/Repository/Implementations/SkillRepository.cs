using Microsoft.EntityFrameworkCore;
using Resume.DataAccess.Context;
using Resume.DataAccess.Repository.Interfaces;
using Resume.Domain.Models;

namespace Resume.DataAccess.Repository.Implementations
{
    public class SkillRepository : BaseRepository<Skill>, ISkillRepository
    {
        private readonly AppDbContext _context;
        public SkillRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Skill> GetByNameAsync(string name)
        {
            return await _context.Skills.FirstOrDefaultAsync(s => s.Name.ToLower() == name.ToLower());
        }
    }
}

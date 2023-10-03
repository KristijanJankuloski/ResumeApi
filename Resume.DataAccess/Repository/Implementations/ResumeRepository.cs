using Microsoft.EntityFrameworkCore;
using Resume.DataAccess.Context;
using Resume.DataAccess.Repository.Interfaces;
using Resume.Domain.Models;

namespace Resume.DataAccess.Repository.Implementations
{
    public class ResumeRepository : BaseRepository<UserResume>, IResumeRepository
    {
        private readonly AppDbContext _context;
        public ResumeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<UserResume> GetByIdAsync(int id)
        {
            return await _context.Resumes
                .Include(r => r.User)
                .Include(r => r.WorkExperiences)
                .Include(r => r.Education)
                .Include(r => r.Skills)
                .ThenInclude(s => s.Skill)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

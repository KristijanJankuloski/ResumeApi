using Resume.Domain.Models;

namespace Resume.DataAccess.Repository.Interfaces
{
    public interface ISkillRepository : IRepository<Skill>
    {
        Task<Skill> GetByNameAsync(string name);
    }
}

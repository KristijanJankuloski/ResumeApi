using Resume.DataAccess.Repository.Interfaces;
using Resume.Domain.Models;
using Resume.DTOs.SkillDTOs;
using Resume.Mappers;
using Resume.Services.Interfaces;
using Resume.Shared.Response;

namespace Resume.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public async Task<Response> Create(string skill)
        {
            skill = skill.Trim();
            if (string.IsNullOrEmpty(skill)) 
                return new Response("Skill is not provided");

            Skill foundSkill = await _skillRepository.GetByNameAsync(skill);
            if (foundSkill != null)
                return new Response("Skill already exists");

            await _skillRepository.InsertAsync(new Skill { Name = skill });
            return Response.Success;
        }

        public async Task<List<SkillListDto>> GetAll()
        {
            List<Skill> skills = await _skillRepository.GetAllAsync();
            return skills.Select(s => s.ToListDto()).ToList();
        }
    }
}

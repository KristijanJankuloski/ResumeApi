using Resume.Domain.Models;
using Resume.DTOs.SkillDTOs;

namespace Resume.Mappers
{
    public static class SkillMappers
    {
        public static SkillListDto ToListDto(this Skill skill)
        {
            return new SkillListDto
            {
                Id = skill.Id,
                Name = skill.Name,
            };
        }
    }
}

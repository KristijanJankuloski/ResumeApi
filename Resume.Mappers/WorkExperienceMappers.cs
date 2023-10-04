using Resume.Domain.Models;
using Resume.DTOs.ExperienceDTOs;

namespace Resume.Mappers
{
    public static class WorkExperienceMappers
    {
        public static WorkExperienceDto ToDto(this WorkExperience workExperience)
        {
            return new WorkExperienceDto
            {
                CompanyName = workExperience.CompanyName,
                Position = workExperience.Position,
                Description = workExperience.Description,
                StartDate = workExperience.StartDate,
                EndDate = workExperience.EndDate,
            };
        }
    }
}

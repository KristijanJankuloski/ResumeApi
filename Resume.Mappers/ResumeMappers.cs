using Resume.Domain.Models;
using Resume.DTOs.ResumeDTOs;

namespace Resume.Mappers
{
    public static class ResumeMappers
    {
        public static ResumeDetailsDto ToDetailsDto(this UserResume resume)
        {
            return new ResumeDetailsDto
            {
                FirstName = resume.User.FirstName ?? "/",
                LastName = resume.User.LastName ?? "/",
                Email = resume.Email ?? "/",
                PhoneNumber = resume.PhoneNumber ?? "/",
                Overview = resume.Overview ?? "/",
                Skills = resume.Skills.Select(s => s.Skill.Name).ToList(),
                Education = resume.Education.Select(e => e.ToDto()).ToList(),
                WorkExperience = resume.WorkExperiences.Select(w => w.ToDto()).ToList()
            };
        }
    }
}

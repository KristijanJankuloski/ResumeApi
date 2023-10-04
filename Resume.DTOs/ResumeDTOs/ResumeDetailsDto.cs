using Resume.DTOs.EducationDTOs;
using Resume.DTOs.ExperienceDTOs;

namespace Resume.DTOs.ResumeDTOs
{
    public class ResumeDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? Overview { get; set; }
        public List<string> Skills { get; set; }
        public List<WorkExperienceDto> WorkExperience { get; set; }
        public List<EducationDto> Education { get; set; }
    }
}

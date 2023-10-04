using Resume.DTOs.EducationDTOs;
using System.ComponentModel.DataAnnotations;

namespace Resume.DTOs.ResumeDTOs
{
    public class ResumeCreateDto
    {
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(350)]
        public string? Overview { get; set; }

        public int[] SkillIds { get; set; }

        public EducationCreateDto[] Education { get; set; }
    }
}

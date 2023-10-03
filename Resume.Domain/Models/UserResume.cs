using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Domain.Models
{
    public class UserResume : BaseEntity
    {
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [MaxLength(350)]
        public string? Overview { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }

        public List<ResumeSkills> Skills { get; set; } = new();

        public List<WorkExperience> WorkExperiences { get; set; } = new();

        public List<EducationEntry> Education {  get; set; } = new();

        public List<Certification> Certifications { get; set; } = new();
    }
}

using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.Models
{
    public class Skill: BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public List<ResumeSkills> Resumes { get; set; } = new();
    }
}

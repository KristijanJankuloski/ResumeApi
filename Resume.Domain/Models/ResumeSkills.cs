using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Domain.Models
{
    public class ResumeSkills: BaseEntity
    {
        [Required]
        public int SkillId { get; set; }

        [ForeignKey(nameof(SkillId))]
        public Skill Skill { get; set; }

        [Required]
        public int ResumeId { get; set;}

        [ForeignKey(nameof(ResumeId))]
        public UserResume Resume { get; set; }
    }
}

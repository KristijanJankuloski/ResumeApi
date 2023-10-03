using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Domain.Models
{
    public class EducationEntry : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string InstitutionName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(250)]
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public int ResumeId { get; set; }

        [ForeignKey(nameof(ResumeId))]
        public UserResume Resume { get; set; }
    }
}

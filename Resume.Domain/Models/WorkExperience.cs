using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Domain.Models
{
    public class WorkExperience : BaseEntity
    {
        [Required]
        public int ResumeId { get; set; }

        [ForeignKey(nameof(ResumeId))]
        public UserResume Resume { get; set; }

        [Required]
        [MaxLength(70)]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [MaxLength(70)]
        public string Position { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Domain.Models
{
    public class Certification : BaseEntity
    {
        [Required]
        [MaxLength(70)]
        public string Issuer { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string CertificateTitle { get; set; } = string.Empty;

        [Required]
        public DateTime IssueDate { get; set; }

        [MaxLength(250)]
        public string? CertificationLink { get; set; }

        [MaxLength(100)]
        public string? CertificationId { get; set; }

        [Required]
        public int ResumeId { get; set; }

        [ForeignKey(nameof(ResumeId))]
        public UserResume Resume { get; set; }
    }
}

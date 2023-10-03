using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Domain.Models
{
    public class User : IdentityUser
    {
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [ForeignKey(nameof(ResumeId))]
        public UserResume? Resume { get; set; }

        public int? ResumeId { get; set; }
    }
}

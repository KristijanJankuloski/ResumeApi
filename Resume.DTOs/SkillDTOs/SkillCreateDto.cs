using System.ComponentModel.DataAnnotations;

namespace Resume.DTOs.SkillDTOs
{
    public class SkillCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}

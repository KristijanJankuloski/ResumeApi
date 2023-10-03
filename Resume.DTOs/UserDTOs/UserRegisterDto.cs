using System.ComponentModel.DataAnnotations;

namespace Resume.DTOs.UserDTOs
{
    public class UserRegisterDto
    {
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [MinLength(6)]
        public string ConfirmPassword { get; set; }
    }
}

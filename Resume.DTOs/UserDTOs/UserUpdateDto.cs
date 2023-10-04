using System.ComponentModel.DataAnnotations;

namespace Resume.DTOs.UserDTOs
{
    public class UserUpdateDto
    {
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }
    }
}

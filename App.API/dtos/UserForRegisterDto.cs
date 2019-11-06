using System.ComponentModel.DataAnnotations;

namespace App.API.dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password")]
        public string Password { get; set; }
    }
}
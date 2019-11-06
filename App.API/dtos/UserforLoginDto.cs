using System.ComponentModel.DataAnnotations;

namespace App.API.dtos
{
    public class UserforLoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace PizzAPI.DTOs
{
    public class LoginRequestDto
    {
        [Required]
        public string? Email { get; set; }
    }
}
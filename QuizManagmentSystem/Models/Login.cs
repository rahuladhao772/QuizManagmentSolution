using System.ComponentModel.DataAnnotations;

namespace QuizManagmentSystem.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Email Id Is Required field")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password Is Required field")]
        public string? password { get; set; }
    }
}

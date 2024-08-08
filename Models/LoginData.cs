using System.ComponentModel.DataAnnotations;

namespace FirstWebMvc.Models
{
    public class LoginData
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Text here")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Text here")]
        public string Password { get; set; }

    }
    public class SignUpData
    {
        public int Id { get; set; }
        [Required]
        public string? Fname { get; set; }
        [Required]
        public string? Lname { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? gender { get; set; }
        [Required]
        public long mobile { get; set; }
        [Required]
        public string? Address { get; set; }
    }
}
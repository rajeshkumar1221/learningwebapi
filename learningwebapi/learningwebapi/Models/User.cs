using System.ComponentModel.DataAnnotations;

namespace SampleWebApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        // Optionally add roles, emails, or other properties as needed
    }
}

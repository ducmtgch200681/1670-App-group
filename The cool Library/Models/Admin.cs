using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Fullname must be at least 5 characters !"),
        MaxLength(30, ErrorMessage = "Fullname maximum is 30 characters !")]
        public string Ad_name { get; set; }

        [Required]
        [EmailAddress]
        public string Ad_email { get; set; }
    }
}
    
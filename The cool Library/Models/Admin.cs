using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Admin
    {
        public int Ad_id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Fullname must be at least 5 characters !"),
        MaxLength(30, ErrorMessage = "Fullname maximum is 30 characters !")]
        public string Ad_name { get; set; }

        [Required]
        [EmailAddress]
        public string Ad_email { get; set; }
    }
}
    
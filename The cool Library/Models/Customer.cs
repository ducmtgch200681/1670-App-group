using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Customer
    {
        public int id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Fullname must be at least 5 characters !"), MaxLength(30, ErrorMessage = "Fullname maximum is 30 characters !")]
        public string fullname { get; set; }

        [Required]
        [Range(4,6, ErrorMessage = "Gender range must from 4-6 characters !")]
        public string gender { get; set; }

        [Required]
        [Phone]
        public int phone { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}

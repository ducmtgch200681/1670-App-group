using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class GenreRequest
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}

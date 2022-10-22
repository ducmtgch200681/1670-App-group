using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Genre")]
        public string Genre_name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

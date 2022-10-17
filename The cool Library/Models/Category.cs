using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Category
    {
        [Key]
        public int Cate_id { get; set; }

        [Required(ErrorMessage = "Enter category")]
        public string Cate_name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

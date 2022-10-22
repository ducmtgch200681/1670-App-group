using System;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter book title")]
        [MinLength(2, ErrorMessage ="Title must have at least 2 characters")]
        [MaxLength(100, ErrorMessage ="Max length of title is 20 characters")]
        public string Book_name { get; set; }

        [Required(ErrorMessage ="Input book author")]
        [MinLength(2, ErrorMessage = "Title must have at least 2 characters")]
        [MaxLength(30, ErrorMessage = "Max length of title is 20 characters")]
        public string Book_author { get; set; }

        [Required(ErrorMessage ="Book publisher is required")]
        [MinLength(2, ErrorMessage = "Publisher must have at least 2 characters")]
        [MaxLength(50, ErrorMessage = "Max length of Publisher is 20 characters")]
        public string Book_publisher { get; set; }

        [Required(ErrorMessage ="Date of publisher is required")]
        [DataType(DataType.Date)]
        public DateTime Book_date { get; set; }

        [Required(ErrorMessage ="Enter book price here")]
        public double Book_price { get; set; }

        [Required(ErrorMessage ="Enter book image link here")]
        public string Book_image { get; set; }

        [Required(ErrorMessage ="Enter book description here")]
        public string Book_description { get; set; }

        [Required(ErrorMessage ="Enter quantity")]
        public int Book_quantity { get; set; }


        // bổ sung khóa phụ của category id: Cate_id sau 
        [Required]
        public int Genre_id { get; set; }
        public Genre Genre { get; set; }


    }
}

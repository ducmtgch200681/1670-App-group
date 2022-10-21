﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Genre
    {
        [Key]
        public int Genre_id { get; set; }

        [Required(ErrorMessage = "Enter Genre")]
        public string Genre_name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
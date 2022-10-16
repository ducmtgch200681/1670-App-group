using System;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Customer
    {
        public int Cus_id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Fullname must be at least 5 characters !"), 
        MaxLength(30, ErrorMessage = "Fullname maximum is 30 characters !")]
        public string Cus_name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Cus_dob { get; set; }

        [Required]
        [EmailAddress]
        public string Cus_email { get; set; }

        [Required (ErrorMessage = "Please input your address !")]
        public string Cus_address { get; set; }

        [Required]
        [Phone] 
        public string Cus_phone { get; set; }


        [Required (ErrorMessage = "Please input your gender !")]
        public char gender { get; set; }



       
    }
}

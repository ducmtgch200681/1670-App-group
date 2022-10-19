using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class Customer : IdentityUser
    {
        //[Key]
        //public int Cus_id { get; set; }

        [MinLength(5, ErrorMessage = "Fullname must be at least 5 characters !"), 
        MaxLength(30, ErrorMessage = "Fullname maximum is 30 characters !")]
        public string Cus_name { get; set; }


        [DataType(DataType.Date)]
        public DateTime Cus_dob { get; set; }

        public string Cus_address { get; set; }

        [Phone] 
        public string Cus_phone { get; set; }

        public char gender { get; set; }

       
    }
}

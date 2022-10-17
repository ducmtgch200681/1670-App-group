using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class StoreOwner
    {
        [Key]
        public int So_id { get; set; }

        [Required(ErrorMessage ="Please enter store owner username")]
        [MinLength(5, ErrorMessage ="Username must at least 5 characters")]
        [MaxLength(20, ErrorMessage ="Username has max is 20 characeters")]
        public string So_username { get; set; }

        //Phần này password lm sau !!!!-----------------
        //[Required(ErrorMessage ="Enter password here")]
        //[PasswordPropertyText]
        //public string So_pass { get; set; }
        //-----------------------------------------------

        [Required(ErrorMessage ="Enter name of store owner here")]
        [MinLength(5, ErrorMessage = "Name must at least 5 characters")]
        [MaxLength(20, ErrorMessage = "Name has max is 20 characeters")]
        public string So_name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Please enter your email")]
        public string So_email { get; set; }
    }
}

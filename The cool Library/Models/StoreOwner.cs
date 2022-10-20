using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace The_cool_Library.Models
{
    public class StoreOwner : IdentityUser
    {
        //[Key]
        //public int So_id { get; set; }

        [Required(ErrorMessage ="Enter name of store owner here")]
        [MinLength(5, ErrorMessage = "Name must at least 5 characters")]
        [MaxLength(20, ErrorMessage = "Name has max is 20 characeters")]
        public string So_name { get; set; }

    }
}

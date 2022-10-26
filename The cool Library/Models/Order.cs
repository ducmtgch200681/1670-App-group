using Microsoft.AspNetCore.Identity;
using System;

namespace The_cool_Library.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Bill { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int IdentityUserId { get; set; }
        public IdentityUser IUs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Centrumbiblioteket.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; } 
        public Book Book { get; set; }
        [Required]
        public int BookId { get; set; }
        public List<Rental> Rentals { get; set; }
        //public Rental Rental { get; set; }
        public int? RentalId { get; set; }

        //Kan vara fel här, får kolla upp det!
        //Får också kolla upp ifall det ska vara lista här för relationen.
    }
}

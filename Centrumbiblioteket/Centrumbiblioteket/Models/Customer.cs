using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Centrumbiblioteket.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [Range(0, 100000000)]
        public long TelephoneNumber { get; set; }
        [Required]
        //[Column(TypeName = "VARCHAR")]
        [MaxLength(40), MinLength(2, ErrorMessage = "Uppge namn med bokstäver, försök igen!")]

        public string CustomerFirstName { get; set; }
        [Required]
        //[Column(TypeName = "VARCHAR")]
        [MaxLength(40), MinLength(2, ErrorMessage = "Uppge efternamn med bokstäver, försök igen!")]

        public string CustomerLastName { get; set; }
        [Required]
        [Range(0, 100000000)]
        public long LibraryCard { get; set; }
        public Rental Rental { get; set; }
    }
}

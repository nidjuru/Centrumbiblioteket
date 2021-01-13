using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Centrumbiblioteket.Models;

namespace Centrumbiblioteket.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        //[Column(TypeName = "VARCHAR")]
        [MaxLength(40), MinLength(2, ErrorMessage = "Vänligen använd bokstäver när du ska lägga in en ny bok!")]
        public string Title { get; set; }
        [Required]
        [Range(0, 2020, ErrorMessage = "Ange ett årtal med 4 siffror!")]
        public int ReleaseYear { get; set; }
        [Required]
        [Range(0, 9999999999999, ErrorMessage = "ISBN består utav 13 siffror, vänligen försök igen.")]

        public long ISBN { get; set; }

        public Rating Rating { get; set; }
        [Required]
        public int RatingId { get; set; }
        public List<Book_Author> Book_Authors { get; set; }
        public Inventory Inventory { get; set; }
    }
}

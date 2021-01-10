using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Centrumbiblioteket.Models
{
    public class Book_Author
    {
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [Required]

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

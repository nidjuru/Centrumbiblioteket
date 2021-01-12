using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Centrumbiblioteket.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required]
        //[Column(TypeName = "VARCHAR")]
        [MaxLength(40), MinLength(2, ErrorMessage = "Vänligen använd bokstäver!")]
        public string AuthorFirstName { get; set; }
        [Required]
        //[Column(TypeName = "VARCHAR")]
        [MaxLength(40), MinLength(2, ErrorMessage = "Vänligen använd bokstäver!")]
        public string AuthorLastName { get; set; }
        public List<Book_Author> Book_Authors { get; set; }
    }
}

// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Author name is required")]
        [StringLength(50, ErrorMessage = "Author name can't be more than 50 characters")]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

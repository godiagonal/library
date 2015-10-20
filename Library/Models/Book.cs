using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ISBN { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<BookCopy> BookCopies { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
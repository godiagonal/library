// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title can't be more than 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "ISBN is required")]
        [StringLength(50, ErrorMessage = "ISBN can't be more than 50 characters")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public virtual Author Author { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(150, ErrorMessage = "Description can't be more than 150 characters")]
        public string Description { get; set; }

        public virtual ICollection<BookCopy> BookCopies { get; set; }

        /// <summary>
        /// Copies of the book that are not currently on loan
        /// </summary>
        [NotMapped]
        public List<BookCopy> AvailableBookCopies
        {
            get
            {
                if (BookCopies != null)
                {
                    return BookCopies.Where(b => b.CurrentLoan == null).ToList();
                }
                else
                {
                    return new List<BookCopy>();
                }
            }
            private set
            {

            }
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
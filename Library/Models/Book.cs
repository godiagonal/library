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

        [NotMapped]
        public bool Available
        {
            get
            {
                if (BookCopies != null)
                {
                    var availableCopies = BookCopies.FirstOrDefault(b => b.CurrentLoan == null);
                    return availableCopies == null ? false : true;
                }
                else
                {
                    return false;
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
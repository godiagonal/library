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
    public class Loan
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime TimeOfLoan { get; set; }

        [Required(ErrorMessage = "Due date is required")]
        public DateTime DueDate { get; set; }

        public DateTime? TimeOfReturn { get; set; }

        [Required(ErrorMessage = "Book copy is required")]
        public virtual BookCopy BookCopy { get; set; }

        [Required(ErrorMessage = "Member is required")]
        public virtual Member Member { get; set; }
    }
}

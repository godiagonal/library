using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        public virtual BookCopy BookCopy {get; set;}
        public virtual Member Member {get; set;}
    }
}

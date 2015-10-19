using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PersonalNumber { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

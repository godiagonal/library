using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Personal number is required")]
        [StringLength(25, ErrorMessage = "Personal number can't be more than 25 characters")]
        public string PersonalNumber { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be more than 50 characters")]
        public string Name { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }

        [NotMapped]
        public List<Loan> ActiveLoans
        {
            get
            {
                if (Loans != null)
                {
                    return Loans.Where(l => l.TimeOfReturn == null).ToList();
                }
                else
                {
                    return new List<Loan>();
                }

            }
            private set
            {

            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookCopy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Book Book { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }

        [NotMapped]
        public Loan CurrentLoan
        {
            get 
            {
                if (Loans != null)
                {
                    var loan = Loans.FirstOrDefault(l => l.TimeOfReturn == null);
                    return loan;
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                
            }
        }

        public override string ToString()
        {
            return String.Format("{0} #{1}", this.Book == null ? "" : this.Book.Title, this.Id.ToString());
        }
    }
}
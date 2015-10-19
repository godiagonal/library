using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };

            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo",
                Author = alexDumas,
                ISBN = "12134324325",
                Description = "Lorem ipsum"
            };

            BookCopy monteCristo1 = new BookCopy()
            {
                Book = monteCristo
            };

            Member samuelJ = new Member()
            {
                Name = "Samuel Johansson",
                PersonalNumber = "5465421"
            };

            Loan loan1 = new Loan()
            {
                Member = samuelJ,
                TimeOfLoan = DateTime.Now,
                BookCopy = monteCristo1,
                DueDate = DateTime.Now.AddDays(15)
            };

            samuelJ.Loans = new List<Loan>() { loan1 };
            
            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);
            context.BookCopies.Add(monteCristo1);
            context.Members.Add(samuelJ);
            context.Loans.Add(loan1);
            context.Authors.Add(alexDumas);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}

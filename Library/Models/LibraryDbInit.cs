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


            Member samuelJ = new Member()
            {
                Name = "Samuel Johansson",
                PersonalNumber = "5465421"
            };

            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };

            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo",
                Author = alexDumas,
                ISBN = "12134324325",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris porta nunc at nulla rutrum cursus. Aliquam ac tempus odio. Proin in ante orci. Vestibulum gravida risus sed justo dignissim, vel venenatis velit tempor. Morbi venenatis, lectus in tempus accumsan, nunc ex pretium neque, ut fringilla dolor libero et nibh. Nunc nec eros leo. Quisque arcu sapien, suscipit dictum urna sed, commodo vehicula diam."
            };

            Book book2 = new Book()
            {
                Title = "Testboken hallåa gallåasdfpg43 34t ddfa",
                Author = alexDumas,
                ISBN = "543252345453",
                Description = "Lorem ipsum"
            };

            BookCopy monteCristo1 = new BookCopy()
            {
                Book = monteCristo
            };

            BookCopy monteCristo2 = new BookCopy()
            {
                Book = monteCristo
            };

            Loan loan1 = new Loan()
            {
                Member = samuelJ,
                TimeOfLoan = DateTime.Now,
                BookCopy = monteCristo1,
                DueDate = DateTime.Now.AddDays(15)
            };

            Loan loan2 = new Loan()
            {
                Member = samuelJ,
                TimeOfLoan = DateTime.Now,
                BookCopy = monteCristo1,
                DueDate = DateTime.Now,
                TimeOfReturn = DateTime.Now
            };

            Loan loan3 = new Loan()
            {
                Member = samuelJ,
                TimeOfLoan = DateTime.Now,
                BookCopy = monteCristo2,
                DueDate = DateTime.Now
            };

            samuelJ.Loans = new List<Loan>() { loan1, loan2, loan3 };
            
            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);
            context.Books.Add(book2);
            context.BookCopies.Add(monteCristo1);
            context.BookCopies.Add(monteCristo2);
            context.Members.Add(samuelJ);
            context.Loans.Add(loan1);
            context.Loans.Add(loan2);
            context.Loans.Add(loan3);
            context.Authors.Add(alexDumas);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}

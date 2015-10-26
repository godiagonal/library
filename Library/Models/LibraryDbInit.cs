// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

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

            // Members
            Member samuel = new Member()
            {
                Name = "Samuel Johansson",
                PersonalNumber = "19901226"
            };

            Member lukas = new Member()
            {
                Name = "Lukas Peterson",
                PersonalNumber = "18670723"
            };

            Member sven = new Member()
            {
                Name = "Sven Svensson",
                PersonalNumber = "19500721"
            };

            Member stackis = new Member()
            {
                Name = "Stack Overflow",
                PersonalNumber = "11670723"
            };

            // Authors
            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };

            Author danBrown = new Author()
            {
                Name = "Dan Brown"
            };

            // Books
            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo",
                Author = alexDumas,
                ISBN = "12134324325",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed dui fringilla, cursus dui quis, volutpat nibh. Pellentesque eget eleifend dui."
            };

            Book musketeers = new Book()
            {
                Title = "The Three Musketeers",
                Author = alexDumas,
                ISBN = "5329485434",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed dui fringilla, cursus dui quis, volutpat nibh. Pellentesque eget eleifend dui."
            };

            Book daVinciCode = new Book()
            {
                Title = "The Da Vinci Code",
                Author = danBrown,
                ISBN = "543252345453",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed dui fringilla, cursus dui quis, volutpat nibh. Pellentesque eget eleifend dui."
            };

            Book inferno = new Book()
            {
                Title = "Inferno",
                Author = danBrown,
                ISBN = "545432523453",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed dui fringilla, cursus dui quis, volutpat nibh. Pellentesque eget eleifend dui."
            };

            Book lostSymbol = new Book()
            {
                Title = "The Lost Symbol",
                Author = danBrown,
                ISBN = "765049393034",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed dui fringilla, cursus dui quis, volutpat nibh. Pellentesque eget eleifend dui."
            };

            // Copies
            BookCopy monteCristo1 = new BookCopy()
            {
                Book = monteCristo
            };

            BookCopy monteCristo2 = new BookCopy()
            {
                Book = monteCristo
            };

            BookCopy daVinciCode1 = new BookCopy()
            {
                Book = daVinciCode
            };

            BookCopy daVinciCode2 = new BookCopy()
            {
                Book = daVinciCode
            };

            BookCopy inferno1 = new BookCopy()
            {
                Book = inferno
            };

            BookCopy inferno2 = new BookCopy()
            {
                Book = inferno
            };

            BookCopy inferno3 = new BookCopy()
            {
                Book = inferno
            };

            BookCopy lostSymbol1 = new BookCopy()
            {
                Book = lostSymbol
            };

            // Loans
            Loan monteCristoLoan1 = new Loan()
            {
                Member = samuel,
                TimeOfLoan = DateTime.Now,
                BookCopy = monteCristo1,
                DueDate = DateTime.Now.AddDays(15)
            };

            Loan monteCristoLoan2 = new Loan()
            {
                Member = samuel,
                TimeOfLoan = DateTime.Now.AddDays(-15),
                BookCopy = monteCristo1,
                DueDate = DateTime.Now,
                TimeOfReturn = DateTime.Now
            };

            Loan monteCristoLoan3 = new Loan()
            {
                Member = sven,
                TimeOfLoan = DateTime.Now.AddDays(-30),
                BookCopy = monteCristo2,
                DueDate = DateTime.Now.AddDays(-15)
            };

            Loan infernoLoan1 = new Loan()
            {
                Member = lukas,
                TimeOfLoan = DateTime.Now.AddDays(-30),
                BookCopy = inferno1,
                DueDate = DateTime.Now.AddDays(-15)
            };

            Loan infernoLoan2 = new Loan()
            {
                Member = sven,
                TimeOfLoan = DateTime.Now,
                BookCopy = inferno2,
                DueDate = DateTime.Now.AddDays(15)
            };

            Loan daVinciLoan1 = new Loan()
            {
                Member = samuel,
                TimeOfLoan = DateTime.Now.AddDays(-30),
                BookCopy = daVinciCode2,
                DueDate = DateTime.Now.AddDays(-15),
                TimeOfReturn = DateTime.Now.AddDays(-10)
            };

            Loan daVinciLoan2 = new Loan()
            {
                Member = lukas,
                TimeOfLoan = DateTime.Now.AddDays(-10),
                BookCopy = daVinciCode1,
                DueDate = DateTime.Now.AddDays(-5)
            };

            Loan lostSymbolLoan1 = new Loan()
            {
                Member = samuel,
                TimeOfLoan = DateTime.Now.AddDays(-15),
                BookCopy = lostSymbol1,
                DueDate = DateTime.Now,
                TimeOfReturn = DateTime.Now.AddDays(-5)
            };

            Loan lostSymbolLoan2 = new Loan()
            {
                Member = stackis,
                TimeOfLoan = DateTime.Now.AddDays(-25),
                BookCopy = lostSymbol1,
                DueDate = DateTime.Now,
                TimeOfReturn = DateTime.Now.AddDays(-16)
            };

            // Add the objects to the DbSet
            context.Members.Add(samuel);
            context.Members.Add(lukas);
            context.Members.Add(sven);
            context.Members.Add(stackis);
            context.Books.Add(monteCristo);
            context.Books.Add(musketeers);
            context.Books.Add(daVinciCode);
            context.Books.Add(inferno);
            context.Books.Add(lostSymbol);
            context.BookCopies.Add(monteCristo1);
            context.BookCopies.Add(monteCristo2);
            context.BookCopies.Add(daVinciCode1);
            context.BookCopies.Add(daVinciCode2);
            context.BookCopies.Add(inferno1);
            context.BookCopies.Add(inferno2);
            context.BookCopies.Add(inferno3);
            context.BookCopies.Add(lostSymbol1);
            context.Loans.Add(monteCristoLoan1);
            context.Loans.Add(monteCristoLoan2);
            context.Loans.Add(monteCristoLoan3);
            context.Loans.Add(infernoLoan1);
            context.Loans.Add(infernoLoan2);
            context.Loans.Add(daVinciLoan1);
            context.Loans.Add(daVinciLoan2);
            context.Loans.Add(lostSymbolLoan1);
            context.Authors.Add(alexDumas);
            context.Authors.Add(danBrown);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}

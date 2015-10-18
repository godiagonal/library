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

            // Create the author-object
            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };

            // Create the book-object and assign the 
            // Author-property with the author
            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo",
                Author = alexDumas
            };

            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}

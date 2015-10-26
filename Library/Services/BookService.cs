// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using Library.Helpers;
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    /// <summary>
    /// Basic operations on the Book model that are exposed to the GUI classes
    /// </summary>
    public class BookService : IService
    {
        BookRepository _bookRepository;

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        /// <summary>
        /// Find books by title or author name
        /// </summary>
        /// <param name="keyword">Search term; title or author</param>
        /// <param name="availableOnly">Show only books with available copies</param>
        /// <returns></returns>
        public IEnumerable<Book> Search(string keyword, bool availableOnly)
        {
            var books = _bookRepository.All();

            if (keyword.Length != 0)
                books = books.Where(b => b.Title.ToLower().Contains(keyword.ToLower()) || b.Author.Name.ToLower().Contains(keyword.ToLower()));

            if (availableOnly)
                books = books.Where(b => b.AvailableBookCopies.Count() > 0);

            return books;
        }

        /// <summary>
        /// Add new book
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isbn"></param>
        /// <param name="author"></param>
        /// <param name="noOfCopies"></param>
        public void Add(string title, string description, string isbn, Author author, int noOfCopies)
        {
            if (ContainsTitle(title))
            {
                throw new ValidationException("The title you are trying to add already exists");
            }
            else if (ContainsISBN(isbn))
            {
                throw new ValidationException("The ISBN you are trying to add already exists");
            }

            Book book = new Book()
            {
                Title = title,
                Description = description,
                ISBN = isbn,
                Author = author
            };

            // Add book copies to the new book
            List<BookCopy> bookCopies = new List<BookCopy>();
            for (int i = 0; i < noOfCopies; i++)
            {
                bookCopies.Add(new BookCopy() {Book = book});
            }

            book.BookCopies = bookCopies;

            ValidationResult error = ObjectValidator.Validate(book);

            if (error != null)
            {
                throw new ValidationException(error.ErrorMessage);
            }
            else
            {
                _bookRepository.Add(book);
                OnUpdated(new EventArgs());
            } 
        }

        /// <summary>
        /// Find book by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book Find(int id)
        {
            return _bookRepository.Find(id);
        }

        /// <summary>
        /// Check if the db already contains a given title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private bool ContainsTitle(string title)
        {
            var book = _bookRepository.All().FirstOrDefault(b => b.Title.ToLower() == title.ToLower());
            return book == null ? false : true;
        }

        /// <summary>
        /// Check if the db already contains a given ISBN
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        private bool ContainsISBN(string isbn)
        {
            var book = _bookRepository.All().FirstOrDefault(b => b.ISBN.ToLower() == isbn.ToLower());
            return book == null ? false : true;
        }

        /// <summary>
        /// Event that's executed on Add, Remove and Edit
        /// </summary>
        public event EventHandler Updated;

        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }
    }
}

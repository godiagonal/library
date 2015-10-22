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
    public class BookService : IService
    {
        BookRepository _bookRepository;
        BookCopyService _bookCopyService;

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public BookService(RepositoryFactory repoFactory, BookCopyService bookCopyService)
            : this(repoFactory)
        {
            _bookCopyService = bookCopyService;
            _bookCopyService.Updated += _bookCopyService_Updated;
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public IEnumerable<Book> Search(string keyword, bool available)
        {
            var books = _bookRepository.All();
            if (keyword.Length != 0)
                books = books.Where(b => b.Title.ToLower().Contains(keyword.ToLower()) || b.Author.Name.ToLower().Contains(keyword.ToLower()));
            if (available == true)
                books = books.Where(b => b.Available);
            return books;
        }

        public void Add(string title, string description, string isbn, Author author, int noOfCopies)
        {
            if(ContainsTitle(title))
            {
                throw new ValidationException("The title you are trying to add already exists");
            }
            else if(ContainsISBN(isbn))
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

        public Book Find(int id)
        {
            return _bookRepository.Find(id);
        }

        public event EventHandler Updated;

        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        private void _bookCopyService_Updated(object sender, EventArgs e)
        {
            OnUpdated(e);
        }

        private bool ContainsTitle(string title)
        {
            var book = _bookRepository.All().FirstOrDefault(b => b.Title.ToLower() == title.ToLower());
            return book == null ? false : true;
        }
        private bool ContainsISBN(string isbn)
        {
            var book = _bookRepository.All().FirstOrDefault(b => b.ISBN.ToLower() == isbn.ToLower());
            return book == null ? false : true;
        }
    }
}

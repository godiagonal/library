using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookService : IService
    {
        BookRepository _bookRepository;

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
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

        public void Add(string title, string description, string isbn, Author author)
        {
            Book book = new Book()
            {
                Title = title,
                Description = description,
                ISBN = isbn,
                Author = author
            };

            _bookRepository.Add(book);

            OnUpdated(new EventArgs());
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
    }
}

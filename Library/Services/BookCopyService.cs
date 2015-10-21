using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookCopyService : IService
    {
        BookCopyRepository _bookCopyRepository;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public void Add(Book book)
        {
            BookCopy bookCopy = new BookCopy()
            {
                Book = book
            };

            _bookCopyRepository.Add(bookCopy);

            OnUpdated(new EventArgs());
        }

        public BookCopy Find(int id)
        {
            return _bookCopyRepository.Find(id);
        }

        public event EventHandler Updated;

        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }
    }
}

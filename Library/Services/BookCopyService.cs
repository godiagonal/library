// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    /// <summary>
    /// Basic operations on the BookCopy model that are exposed to the GUI classes
    /// </summary>
    public class BookCopyService : IService
    {
        BookCopyRepository _bookCopyRepository;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        /// <summary>
        /// Get all book copies
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        /// <summary>
        /// Add new book copy
        /// </summary>
        /// <param name="book"></param>
        public void Add(Book book)
        {
            BookCopy bookCopy = new BookCopy()
            {
                Book = book
            };

            _bookCopyRepository.Add(bookCopy);

            OnUpdated(new EventArgs());
        }

        /// <summary>
        /// Find book copy by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BookCopy Find(int id)
        {
            return _bookCopyRepository.Find(id);
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

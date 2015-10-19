using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Book> All()
        {
            return _context.Books.ToList();
        }
        public bool Contains(Book b)
        {
            return _context.Books.Contains(b);
        }
        public void Add(Book b)
        {
            _context.Books.Add(b);
        }
        public void Remove(Book b)
        {
            _context.Books.Remove(b);
        }
    }
}
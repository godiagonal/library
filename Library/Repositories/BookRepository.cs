using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

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

        public Book Find(int id)
        {
            return _context.Books.Find(id);
        }

        public void Add(Book b)
        {
            _context.Books.Add(b);
            _context.SaveChanges();
        }

        public void Remove(Book b)
        {
            _context.Books.Remove(b);
            _context.SaveChanges();
        }

        public void Edit(Book b)
        {
            _context.Books.Attach(b);
            _context.Entry(b).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
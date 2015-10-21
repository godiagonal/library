using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }

        public BookCopy Find(int id)
        {
            return _context.BookCopies.Find(id);
        }

        public void Add(BookCopy b)
        {
            _context.BookCopies.Add(b);
            _context.SaveChanges();
        }

        public void Remove(BookCopy b)
        {
            _context.BookCopies.Remove(b);
            _context.SaveChanges();
        }

        public void Edit(BookCopy b)
        {
            _context.BookCopies.Attach(b);
            _context.Entry(b).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
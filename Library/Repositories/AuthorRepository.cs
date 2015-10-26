// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
    /// <summary>
    /// CRUD operations for Author repository
    /// </summary>
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }

        public Author Find(int id)
        {
            return _context.Authors.Find(id);
        }

        public void Add(Author a)
        {
            _context.Authors.Add(a);
            _context.SaveChanges();
        }

        public void Remove(Author a)
        {
            _context.Authors.Remove(a);
            _context.SaveChanges();
        }

        public void Edit(Author a)
        {
            _context.Authors.Attach(a);
            _context.Entry(a).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
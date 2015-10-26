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
    /// CRUD operations for Loan repository
    /// </summary>
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList();
        }

        public Loan Find(int id)
        {
            return _context.Loans.Find(id);
        }

        public void Add(Loan l)
        {
            _context.Loans.Add(l);
            _context.SaveChanges();
        }

        public void Remove(Loan l)
        {
            _context.Loans.Remove(l);
            _context.SaveChanges();
        }

        public void Edit(Loan l)
        {
            _context.Loans.Attach(l);
            _context.Entry(l).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }

        public Member Find(int id)
        {
            return _context.Members.Find(id);
        }

        public void Add(Member m)
        {
            _context.Members.Add(m);
            _context.SaveChanges();
        }

        public void Remove(Member m)
        {
            _context.Members.Remove(m);
            _context.SaveChanges();
        }

        public void Edit(Member m)
        {
            _context.Members.Attach(m);
            _context.Entry(m).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
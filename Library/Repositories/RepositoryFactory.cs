// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library.Repositories;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles instantiation of the repositories
    /// </summary>
    public class RepositoryFactory
    {
        /// <summary>
        /// Wrapper property to get a context instance
        /// </summary>
        static LibraryContext context
        {
            get { return ContextSingleton.GetContext(); }
        }

        /// <summary>
        /// Retrieve a book repository instance
        /// </summary>
        public BookRepository GetBookRepository()
        {
            return new BookRepository(context);
        }

        /// <summary>
        /// Retrieve a member repository instance
        /// </summary>
        public MemberRepository GetMemberRepository()
        {
            return new MemberRepository(context);
        }

        /// <summary>
        /// Retrieve an author repository instance
        /// </summary>
        public AuthorRepository GetAuthorRepository()
        {
            return new AuthorRepository(context);
        }

        /// <summary>
        /// Retrieve a loan repository instance
        /// </summary>
        public LoanRepository GetLoanRepository()
        {
            return new LoanRepository(context);
        }

        /// <summary>
        /// Retrieve a book copy repository instance
        /// </summary>
        public BookCopyRepository GetBookCopyRepository()
        {
            return new BookCopyRepository(context);
        }
    }
}
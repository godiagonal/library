﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library.Repositories;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles instantiation of the repositories.
    /// </summary>
    public class RepositoryFactory
    {
        /// <summary>
        /// Wrapper property to get a context instance.
        /// </summary>
        static LibraryContext context
        {
            get { return ContextSingleton.GetContext(); }
        }

        /// <summary>
        /// Retrieve a book repository instance.
        /// </summary>
        public BookRepository GetBookRepository()
        {
            return new BookRepository(context);
        }

        // More repositories..
        public MemberRepository GetMemberRepository()
        {
            return new MemberRepository(context);
        }

        public AuthorRepository GetAuthorRepository()
        {
            return new AuthorRepository(context);
        }

        public LoanRepository GetLoanRepository()
        {
            return new LoanRepository(context);
        }

        public BookCopyRepository GetBookCopyRepository()
        {
            return new BookCopyRepository(context);
        }
    }
}
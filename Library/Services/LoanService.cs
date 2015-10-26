// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using Library.Helpers;
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class LoanService : IService
    {
        LoanRepository _loanRepository;

        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        /// <summary>
        /// Get all loans
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

        /// <summary>
        /// Add new loan
        /// </summary>
        /// <param name="member"></param>
        /// <param name="bookCopy"></param>
        /// <param name="AlreadyExpiredLoan">Register as already expired loan for testing purposes</param>
        public void Add(Member member, BookCopy bookCopy, bool alreadyExpiredLoan)
        {
            if (bookCopy != null && bookCopy.CurrentLoan != null)
            {
                throw new ValidationException("This book copy is already on loan");
            }

            Loan loan = new Loan()
            {
                TimeOfLoan = DateTime.Now,
                DueDate = alreadyExpiredLoan ? DateTime.Now.AddDays(-15) : DateTime.Now.AddDays(15),
                Member = member,
                BookCopy = bookCopy
            };

            ValidationResult error = ObjectValidator.Validate(loan);

            if (error != null)
            {
                throw new ValidationException(error.ErrorMessage);
            }
            else
            {
                _loanRepository.Add(loan);
                OnUpdated(new EventArgs());
            }
        }

        /// <summary>
        /// Find loan by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Loan Find(int id)
        {
            return _loanRepository.Find(id);
        }

        /// <summary>
        /// Find all loans or loans by member
        /// </summary>
        /// <param name="member">Member to show loans for, null means all members</param>
        /// <param name="showReturnedLoans">Include returned loans</param>
        /// <returns></returns>
        public IEnumerable<Loan> Search(Member member, bool showReturnedLoans)
        {
            var loans = _loanRepository.All();

            if (member != null)
                loans = loans.Where(l => l.Member.Id == member.Id);

            if (!showReturnedLoans)
                loans = loans.Where(l => l.TimeOfReturn == null);

            return loans;
        }

        /// <summary>
        /// Return loan an calculate fee if loan is returned past it's due date
        /// </summary>
        /// <param name="loan"></param>
        /// <param name="fee">The fee for passing the loan due date</param>
        public void Return(Loan loan, out double fee)
        {
            fee = 0;

            if (loan != null && loan.TimeOfReturn == null)
            {
                // 10 SEK fee per day after due date
                if (DateTime.Now > loan.DueDate)
                    fee = (DateTime.Now - loan.DueDate).Days * 10;

                loan.TimeOfReturn = DateTime.Now;
                OnUpdated(new EventArgs());
            }
            else
                throw new InvalidOperationException("The book you are trying to return has already been returned");
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

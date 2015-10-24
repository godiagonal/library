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

        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

        public void Add(Member member, BookCopy bookCopy, bool AlreadyExpiredLoan)
        {
            if (bookCopy != null && bookCopy.CurrentLoan != null)
            {
                throw new ValidationException("This book copy is already on loan");
            }

            Loan loan = new Loan()
            {
                TimeOfLoan = DateTime.Now,
                DueDate = AlreadyExpiredLoan ? DateTime.Now.AddDays(-15) : DateTime.Now.AddDays(15),
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

        public Loan Find(int id)
        {
            return _loanRepository.Find(id);
        }

        public event EventHandler Updated;

        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public IEnumerable<Loan> ListMemberLoans (Member member, bool returnedLoans)
        {
            var loans = _loanRepository.All();
            if(member != null)
                loans = loans.Where(l => l.Member.Id == member.Id);
            if(returnedLoans == false)
                loans = loans.Where(l => l.TimeOfReturn == null);
            return loans;
        }

        public IEnumerable<Loan> ListLoans(bool returnedLoans)
        {
            var loans = _loanRepository.All();
            if (returnedLoans == false)
                loans = loans.Where(l => l.TimeOfReturn == null);
            return loans;
        }

        public void ReturnLoan(int memberId, int bookCopyId, int bookId)
        {
            Loan loan = _loanRepository.All().FirstOrDefault(l => l.BookCopy.Id == bookCopyId && l.Member.Id == memberId && l.TimeOfReturn == null);

            if (loan != null)
            {
                loan.TimeOfReturn = DateTime.Now;
                OnUpdated(new EventArgs());
            }
            else
                throw new InvalidOperationException("The book you are trying to return, has already been returned");
        }
    }
}

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
    }
}

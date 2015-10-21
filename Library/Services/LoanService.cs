using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
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

        public void Add(Member member, BookCopy bookCopy)
        {
            Loan loan = new Loan()
            {
                TimeOfLoan = new DateTime(),
                Member = member,
                BookCopy = bookCopy,
                DueDate = new DateTime().AddDays(15)
            };

            _loanRepository.Add(loan);

            OnUpdated(new EventArgs());
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

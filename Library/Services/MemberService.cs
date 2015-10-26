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
    /// <summary>
    /// Basic operations on the Member model that are exposed to the GUI classes
    /// </summary>
    public class MemberService : IService
    {
        MemberRepository _memberRepository;

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        /// <summary>
        /// Get all members
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }

        /// <summary>
        /// Search members by name and filter by active loans
        /// </summary>
        /// <param name="keyword">Member name to search for</param>
        /// <param name="hasActiveLoans"></param>
        /// <returns>Only include members with active loans</returns>
        public IEnumerable<Member> Search(string keyword, bool hasActiveLoansOnly)
        {
            var members = _memberRepository.All();

            if (keyword.Length != 0)
                members = members.Where(m => m.Name.ToLower().Contains(keyword.ToLower()));

            if (hasActiveLoansOnly)
                members = members.Where(m => m.ActiveLoans.Count > 0);

            return members;
        }

        /// <summary>
        /// Add new member
        /// </summary>
        /// <param name="name"></param>
        /// <param name="personalNumber"></param>
        public void Add(string name, string personalNumber)
        {
            if (ContainsPersonalNumber(personalNumber))
            {
                throw new ValidationException("The personal number you are trying to add already exists");
            }

            Member member = new Member()
            {
                Name = name,
                PersonalNumber = personalNumber
            };

            ValidationResult error = ObjectValidator.Validate(member);

            if (error != null)
            {
                throw new ValidationException(error.ErrorMessage);
            }
            else
            {
                _memberRepository.Add(member);
                OnUpdated(new EventArgs());
            }
        }

        /// <summary>
        /// Find member by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Member Find(int id)
        {
            return _memberRepository.Find(id);
        }

        /// <summary>
        /// Check if the db already contains a given personal number
        /// </summary>
        /// <param name="personalNumber"></param>
        /// <returns></returns>
        private bool ContainsPersonalNumber(string personalNumber)
        {
            var member = _memberRepository.All().FirstOrDefault(m => m.PersonalNumber.ToLower() == personalNumber.ToLower());
            return member == null ? false : true;
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

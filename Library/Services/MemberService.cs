﻿using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class MemberService : IService
    {
        MemberRepository _memberRepository;

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }

        public IEnumerable<Member> Search(string keyword, bool HasActiveLoans)
        {
            var members = _memberRepository.All();
            if (keyword.Length != 0)
                members = members.Where(m => m.Name.ToLower().Contains(keyword.ToLower()));
            if (HasActiveLoans)
                members = members.Where(m => m.HasActiveLoans);
            return members;
        }

        public void Add(string name, string personalNumber)
        {
            Member member = new Member()
            {
                Name = name,
                PersonalNumber = personalNumber
            };

            _memberRepository.Add(member);

            OnUpdated(new EventArgs());
        }

        public Member Find(int id)
        {
            return _memberRepository.Find(id);
        }

        public event EventHandler Updated;

        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }
    }
}

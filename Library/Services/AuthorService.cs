using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class AuthorService : IService
    {
        AuthorRepository _authorRepository;

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }

        public void Add(string name)
        {
            Author author = new Author()
            {
                Name = name
            };

            _authorRepository.Add(author);

            OnUpdated(new EventArgs());
        }

        public Author Find(int id)
        {
            return _authorRepository.Find(id);
        }

        public event EventHandler Updated;

        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }
        public IEnumerable<Author> Search(string keyword)
        {
            var authors = _authorRepository.All();
            if (keyword.Length != 0)
                authors = authors.Where(a => a.Name.ToLower().Contains(keyword.ToLower()));
            return authors;
        }
    }
}

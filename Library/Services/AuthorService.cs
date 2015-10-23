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
            if (ContainsName(name))
            {
                throw new ValidationException("The author you are trying to add already exists");
            }

            Author author = new Author()
            {
                Name = name
            };

            ValidationResult error = ObjectValidator.Validate(author);

            if (error != null)
            {
                throw new ValidationException(error.ErrorMessage);
            }
            else
            {
                _authorRepository.Add(author);
                OnUpdated(new EventArgs());
            }
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

        private bool ContainsName(string name)
        {
            var author = _authorRepository.All().FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
            return author == null ? false : true;
        }
    }
}

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
    /// Basic operations on the Author model that are exposed to the GUI classes
    /// </summary>
    public class AuthorService : IService
    {
        AuthorRepository _authorRepository;

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        /// <summary>
        /// Get all authors
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }

        /// <summary>
        /// Add new author
        /// </summary>
        /// <param name="name"></param>
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

        /// <summary>
        /// Find author by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Author Find(int id)
        {
            return _authorRepository.Find(id);
        }

        /// <summary>
        /// Check if the db already contains a given author name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool ContainsName(string name)
        {
            var author = _authorRepository.All().FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
            return author == null ? false : true;
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

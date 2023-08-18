using Project.Domain.Entities;
using Project.Data.Repositories;
using Project.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public Author GetAuthorById(int id)
        {
            var author = _authorRepository.GetById(id);
            if (author == null)
            {
                throw new NotFoundException("Author not found");
            }
            return author;
        }

        public List<Author> GetAllAuthors()
        {
            return _authorRepository.GetAll();
        }

        public void AddAuthor(Author author)
        {
            // Implement validation and business rules here
            _authorRepository.Add(author);
        }

        public void UpdateAuthor(Author author)
        {
            // Implement validation and business rules here
            _authorRepository.Update(author);
        }

        public void DeleteAuthor(int id)
        {
            var author = _authorRepository.GetById(id);
            if (author == null)
            {
                throw new NotFoundException("Author not found");
            }
            _authorRepository.Delete(id);
        }
    }
}

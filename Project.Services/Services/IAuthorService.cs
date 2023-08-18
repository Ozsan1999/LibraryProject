using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Services
{
    public interface IAuthorService
    {
        Author GetAuthorById(int id);
        List<Author> GetAllAuthors();
        void AddAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(int id);
    }
}
